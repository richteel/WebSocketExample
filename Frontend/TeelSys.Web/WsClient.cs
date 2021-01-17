using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;
using System.Resources;
using TeelSys.Globalization;

namespace TeelSys.Web
{
    public class WsClient
    {
        /*** Fields and Constants ***/
        #region
        private readonly ClientWebSocket client = null;
        private readonly CancellationTokenSource cts;
        private readonly ResourceManager rm;
        #endregion

        /*** Properties ***/
        #region
        public bool IsConnected { get { return client.State == WebSocketState.Open; } }

        public string ServerName { get; set; }

        public int ServerPort { get; set; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public WsClient(string ServerName, int ServerPort)
        {
            this.ServerName = ServerName;
            this.ServerPort = ServerPort;

            client = new ClientWebSocket();
            cts = new CancellationTokenSource();

            rm = new ResourceManager(this.GetType().FullName, System.Reflection.Assembly.GetExecutingAssembly());

            ConnectToServerAsync();
        }
        #endregion

        /*** Public Events ***/
        #region
        public delegate void ConnectionStateChangedEventHandler(object sender, ConnectionStateChangedEventArgs args);

        public event ConnectionStateChangedEventHandler ConnectionStateChanged;

        void OnConnectionStateChanged()
        {
            ConnectionStateChanged?.Invoke(this, new ConnectionStateChangedEventArgs(IsConnected,
                IsConnected ? LocalizedResourceHelper.GetLocalizedText(rm, "Connected", "Connected") : LocalizedResourceHelper.GetLocalizedText(rm, "NotConnected", "Not Connected")));
        }

        /* --------------------- */

        public delegate void ConnectionErrorEventHandler(object sender, ErrorEventArgs args);

        public event ConnectionErrorEventHandler ConnectionError;

        void OnConnectionError(string Message, string ErrorMessage, string InnerException)
        {
            ConnectionError?.Invoke(this, new ErrorEventArgs(Message, ErrorMessage, InnerException));
        }

        /* --------------------- */

        public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs args);

        public event MessageReceivedEventHandler MessageReceived;

        void OnMessageReceived(string Message)
        {
            MessageReceived?.Invoke(this, new MessageReceivedEventArgs(Message));
        }
        #endregion

        /*** Public Methods ***/
        #region
        public void CloseClientAsync()
        {
            CloseConnectionAsync();
        }

        public void SendAsync(string Message)
        {
            SendMessageAsync(Message);
        }
        #endregion

        /*** Private Methods ***/
        #region
        bool CanSendMessage(string message)
        {
            return IsConnected && !string.IsNullOrEmpty(message);
        }

        async void CloseConnectionAsync()
        {
            if (client.State != WebSocketState.Open)
                return;

            await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "", cts.Token);
            OnConnectionStateChanged();
        }

        async void ConnectToServerAsync()
        {
            Uri connectionUri = new Uri(string.Format("ws://{0}:{1}", ServerName, ServerPort));

            try
            {
                await client.ConnectAsync(connectionUri, cts.Token);
                UpdateClientState();
            }
            catch (Exception e)
            {
                OnConnectionError(LocalizedResourceHelper.GetLocalizedText(rm, "ConnectionErrorMessage", "Error connecting to server"), e.Message, e.InnerException.ToString());
                return;
            }

            await Task.Factory.StartNew(async () =>
            {
                while (client.State == WebSocketState.Open || client.State == WebSocketState.CloseSent)
                {
                    await ReadMessage();
                }

                OnConnectionStateChanged();
            }, cts.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        async Task ReadMessage()
        {
            WebSocketReceiveResult result;
            var message = new ArraySegment<byte>(new byte[4096]);
            do
            {
                result = await client.ReceiveAsync(message, cts.Token);
                if (result.MessageType != WebSocketMessageType.Text)
                    break;
                var messageBytes = message.Skip(message.Offset).Take(result.Count).ToArray();
                string receivedMessage = Encoding.UTF8.GetString(messageBytes);
                Console.WriteLine("{0}: {1}", LocalizedResourceHelper.GetLocalizedText(rm, "Received", "Received"), receivedMessage);
                OnMessageReceived(receivedMessage);
            }
            while (!result.EndOfMessage);
        }

        async void SendMessageAsync(string message)
        {
            if (!CanSendMessage(message))
                return;

            Byte[] byteMessage = Encoding.UTF8.GetBytes(message);
            ArraySegment<Byte> segmnet = new ArraySegment<Byte>(byteMessage);

            await client.SendAsync(segmnet, WebSocketMessageType.Text, true, cts.Token);
        }

        void UpdateClientState()
        {
            OnConnectionStateChanged();
            Console.WriteLine($"{LocalizedResourceHelper.GetLocalizedText(rm, "WebsocketState", "Websocket State")} {client.State}");
        }
        #endregion
    }
}
