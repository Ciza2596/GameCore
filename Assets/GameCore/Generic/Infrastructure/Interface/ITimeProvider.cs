namespace GameCore.Generic.Infrastructure
{
    public interface ITimeProvider
    {
        float GetDeltaTime();
        float GetTotalTime();
    }
}