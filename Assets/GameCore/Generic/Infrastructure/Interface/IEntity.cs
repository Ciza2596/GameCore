namespace GameCore.Generic.Infrastructure
{
    public interface IEntity<T>
    {
        T GetId();
    }
}