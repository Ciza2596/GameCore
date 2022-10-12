using System;
using Zenject;


namespace GameCore.Generic.Infrastructure
{
    public abstract class DomainEventHandler
    {
        //private variable
        private readonly IDomainEventBus _domainEventBus;


        //protected variable
        [Inject]
        protected DomainEventHandler(IDomainEventBus domainEventBus)
        {
            this._domainEventBus = domainEventBus;
        }
        
        protected void Register<T>(Action<T> callBackAction) where T : DomainEvent
        {
            _domainEventBus.Register(callBackAction);
        }
    }
}