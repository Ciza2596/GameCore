using System.Collections.Generic;

namespace GameCore.Generic.Infrastructure
{
    public interface IAggregateRoot : IEntity<string>
    {
        void AddDomainEvent(DomainEvent domainEvent);
        void ClearDomainEvents();
        T FindDomainEvent<T>() where T : DomainEvent;
        List<DomainEvent> GetDomainEvents();
    }
}