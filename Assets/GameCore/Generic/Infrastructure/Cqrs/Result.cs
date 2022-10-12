namespace GameCore.Generic.Infrastructure
{
    public class Result : Output
    {
        private ExitCode _exitCode;
        private string _message;
        private string _id;


        public ExitCode GetExitCode()
        {
            return _exitCode;
        }

        public string GetId()
        {
            return _id;
        }

        public string GetMessage()
        {
            return _message;
        }

        public Output SetExitCode(ExitCode exitCode)
        {
            _exitCode = exitCode;
            return this;
        }

        public void SetId(string id)
        {
            _id = id;
        }

        public virtual Output SetMessage(string message)
        {
            _message = message;
            return this;
        }
    }
}