using System;

namespace WebSocketExample
{
    public class MessageReceivedEventArgs
    {
        /*** Properties ***/
        #region
        public string Message { get; }

        public DateTime Received { get; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public MessageReceivedEventArgs(string Message)
        {
            this.Message = Message;
            Received = DateTime.Now;
        }
        #endregion
    }
}
