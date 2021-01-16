using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WebSocketExample
{
    public partial class Form1 : Form
    {
        /*** Fields and Constants ***/
        #region
        private bool _connected = false;
        private WsClient _client;
        #endregion

        /*** Properties ***/
        #region
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        /*** Public Events ***/
        #region
        #endregion

        /*** Public Methods ***/
        #region
        #endregion

        /*** Protected Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        private delegate void AppendMessageDelegate(string Message, bool sending, bool connectionStatus = false);

        private void AppendMessage(string Message, bool sending, bool connectionStatus = false)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AppendMessageDelegate(AppendMessage), new object[] { Message, sending, connectionStatus });
            }
            else
            {
                if (txtLog.Text.Length > 0)
                    txtLog.AppendText("\r\n");
                else
                    txtLog.AppendText("Sate/Time\tDIR\tMessage\r\n");

                txtLog.Select(txtLog.TextLength, 0);
                if (connectionStatus)
                    txtLog.SelectionColor = Color.Purple;
                else if (sending)
                    txtLog.SelectionColor = Color.Red;
                else
                    txtLog.SelectionColor = Color.Green;

                txtLog.AppendText(string.Format("{0}\t{1}\t{2}", DateTime.Now, connectionStatus ? "" : sending ? "SEND" : "RECV", Message));
            }
        }

        private bool IsUriValid(string server, int port)
        {
            try
            {
                Uri connectionUri = new Uri(string.Format("ws://{0}:{1}", server, port));
                return true;
            }
            catch (UriFormatException e)
            {
                MessageBox.Show(this, string.Format("{0}\r\n{1}", Properties.Resources.InvalidServerOrPort, e.Message), 
                    Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateButtons()
        {
            cmdDisconnect.Enabled = _connected;
            cmdConnect.Enabled = !cmdDisconnect.Enabled;

            lblConnectedStatus.Text = _connected ? Properties.Resources.Connected : Properties.Resources.NotConnected;
        }
        #endregion

        /*** Event Handlers ***/
        #region
        private void Client_ConnectionError(object sender, ErrorEventArgs e)
        {
            AppendMessage(e.Message, false, true);
        }

        private void Client_ConnectionStateChanged(object sender, ConnectionStateChangedEventArgs e)
        {
            _connected = e.IsConnected;

            UpdateButtons();

            AppendMessage(lblConnectedStatus.Text, false, true);
        }

        private void Client_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            AppendMessage(e.Message, false);
        }

        private void CmdConnect_Click(object sender, EventArgs e)
        {
            if (_connected) // Disconnect
            {
                if (_client == null)
                {
                    _connected = false;
                    UpdateButtons();
                    return;
                }
                _client.CloseClientAsync();
            }
            else // Connect
            {
                if (int.TryParse(txtPort.Text, out int port))
                {
                    if (!IsUriValid(txtServer.Text, port))
                    {
                        return;
                    }
                    _client = new WsClient(txtServer.Text, int.Parse(txtPort.Text));
                    _client.ConnectionStateChanged += Client_ConnectionStateChanged;
                    _client.MessageReceived += Client_MessageReceived;
                    _client.ConnectionError += Client_ConnectionError;
                }
                else
                {
                    MessageBox.Show(this, Properties.Resources.PortMustBeAnInteger, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateButtons();
        }

        private void CmdSend_Click(object sender, EventArgs e)
        {
            if (_client == null)
                return;

            AppendMessage(txtSend.Text, true);
            _client.SendAsync(txtSend.Text);

            txtSend.Text = "";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = Properties.Resources.File;
            exitToolStripMenuItem.Text = Properties.Resources.Exit;
            helpToolStripMenuItem.Text = Properties.Resources.Help;
            githubProjectToolStripMenuItem.Text = Properties.Resources.GitHubProject;
            lblConnection.Text = Properties.Resources.Connection;
            lblUrl.Text = Properties.Resources.Server;
            lblPort.Text = Properties.Resources.Port;
            cmdConnect.Text = Properties.Resources.Connect;
            cmdDisconnect.Text = Properties.Resources.Disconnect;
            lblSend.Text = Properties.Resources.MessageToSend;
            cmdSend.Text = Properties.Resources.Send;
            lblMessageLog.Text = Properties.Resources.MessageLog;

            Form1_Resize(sender, e);
            UpdateButtons();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int space = 10;

            cmdConnect.Top = cmdDisconnect.Top = (panButtons.Height - cmdConnect.Height) / 2;
            cmdConnect.Left = (panButtons.Width - cmdConnect.Width - cmdDisconnect.Width - space)/ 2;
            cmdDisconnect.Left = cmdConnect.Left + cmdConnect.Width + space;
        }

        private void GithubProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.GitHubProjectURL);
        }
        #endregion

        private void TextPort_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtPort.Text, out _))
            {
                MessageBox.Show(this, Properties.Resources.PortMustBeAnInteger, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
