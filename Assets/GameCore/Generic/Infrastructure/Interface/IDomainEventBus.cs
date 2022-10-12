
using System;

namespace GameCore.Generic.Infrastructure
{
    public interface IDomainEventBus
    {
        void Post(DomainEvent domainEvent);
        void PostAll(IAggregateRoot aggregateRoot);
        void Register<T>(Action<T> callbackAction) where T : DomainEvent;
    }
}