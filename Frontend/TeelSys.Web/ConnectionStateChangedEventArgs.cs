namespace TeelSys.Web
{
    public class ConnectionStateChangedEventArgs
    {
        /*** Properties ***/
        #region
        public string Message { get; }

        public bool IsConnected { get; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public ConnectionStateChangedEventArgs(bool IsConnected, string Message)
        {
            this.Message = Message;
            this.IsConnected = IsConnected;
        }
        #endregion
    }
}
