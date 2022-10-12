
namespace GameCore.Generic.Infrastructure
{
    public abstract class Entity<T> : IEntity<T>
    {

        //protected variable
        protected readonly T _id;
        
        protected Entity(T id)
        {
            _id = id;
        }
        
        //public method
        public T GetId()
        {
            return _id;
        }
    }
}