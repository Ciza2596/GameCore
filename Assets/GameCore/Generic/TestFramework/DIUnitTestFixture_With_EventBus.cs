


using GameCore.Generic.Infrastructure;


namespace GameCore.Generic.TestFrameWork
{
    public class DIUnitTestFixture_With_EventBus : DIUnitTestFixture
    {

        //protected variable
        protected IDomainEventBus domainEventBus;
        
        
        //public method
        public override void Setup()
        {
            base.Setup();
            BindFromSubstitute<IDomainEventBus>();
            domainEventBus = Resolve<IDomainEventBus>();
        }
    }
}