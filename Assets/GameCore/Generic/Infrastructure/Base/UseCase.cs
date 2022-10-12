

namespace GameCore.Generic.Infrastructure
{
    public abstract class UseCase<I , O , R> where I : Input where O : Output
    {

        //protected variable
        protected readonly IDomainEventBus _domainEventBus;

        protected readonly R _repository;
        

        protected UseCase(IDomainEventBus domainEventBus , R repository)
        {
            _domainEventBus = domainEventBus;
            _repository     = repository;
        }
        
        //public method
        public abstract void Execute(I input , O output);
    }
}