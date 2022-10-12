using System;
using System.Collections.Generic;
using MessagePipe;
using GameCore.Generic.Infrastructure;


namespace GameCore.Generic.Implement
{
    public sealed class DomainEventBus : IDomainEventBus
    {
        //private variable
        private readonly Dictionary<Type , List<Action<DomainEvent>>> _callbackActions
            = new Dictionary<Type , List<Action<DomainEvent>>>();

        private readonly IPublisher<DomainEvent> _publisher;

        
        //public method
        public DomainEventBus(ISubscriber<DomainEvent> subscriber , IPublisher<DomainEvent> publisher)
        {
            _publisher = publisher;
            subscriber.Subscribe(HandleEvent);
        }
        

        public void Post(DomainEvent domainEvent)
        {
            _publisher.Publish(domainEvent);
        }

        public void PostAll(IAggregateRoot aggregateRoot)
        {
            var domainEvents = aggregateRoot.GetDomainEvents();
            // interface don't have domainEvents , this for UnitTest
            if (domainEvents == null) return;
            foreach (var domainEvent in domainEvents)
                Post(domainEvent);
            aggregateRoot.ClearDomainEvents();
        }

        public void Register<T>(Action<T> callbackAction) where T : DomainEvent
        {
            var                       type        = typeof(T);
            var                       isContainsKey = _callbackActions.ContainsKey(type);
            List<Action<DomainEvent>> actions;
            if (isContainsKey)
            {
                actions = _callbackActions[type];
            }
            else
            {
                actions = new List<Action<DomainEvent>>();
                _callbackActions.Add(type , actions);
            }

            actions.Add(@event => callbackAction((T)@event));
        }

        private void HandleEvent(DomainEvent domainEvent)
        {
            var type        = domainEvent.GetType();
            var isContainsKey = _callbackActions.ContainsKey(type);
            if (isContainsKey)
            {
                var callbackActions = _callbackActions[type];
                foreach (var action in callbackActions)
                    action.Invoke(domainEvent);
            }
        }
    }
}