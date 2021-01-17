namespace TeelSys.Web
{
    public class ErrorEventArgs
    {/*** Properties ***/
        #region
        public string Message { get; }

        public string ErrorMessage { get; }

        public string InnerException { get; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public ErrorEventArgs(string Message, string ErrorMessage, string InnerException)
        {
            this.Message = Message;
            this.ErrorMessage = ErrorMessage;
            this.InnerException = InnerException;
        }
        #endregion
    }
}
