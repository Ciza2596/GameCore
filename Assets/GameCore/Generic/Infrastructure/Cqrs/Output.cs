namespace GameCore.Generic.Infrastructure
{
    public interface Output
    {
        ExitCode GetExitCode();
        string   GetMessage();
        Output   SetExitCode(ExitCode exitCode);
        Output   SetMessage(string    message);
    }
}