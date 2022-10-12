using System.Collections.Generic;
using System.Linq;


namespace GameCore.Generic.Infrastructure
{
    public abstract class AggregateRoot : IAggregateRoot
    {
        //private variable
        private readonly string _id;
        private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();


        //protected method
        protected AggregateRoot(string id)
        {
            _id = id;
        }


        //public method
        public void AddDomainEvent(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        public T FindDomainEvent<T>() where T : DomainEvent
        {
            var tEvent = _domainEvents.Find(domainEvent => domainEvent is T);
            return (T)tEvent;
        }

        public IEnumerable<T> FindDomainEvents<T>() where T : DomainEvent
        {
            var events = _domainEvents.FindAll(domainEvent => domainEvent is T).Cast<T>();
            return events;
        }

        public List<DomainEvent> GetDomainEvents()
        {
            return _domainEvents;
        }

        public string GetId()
        {
            return _id;
        }
    }
}