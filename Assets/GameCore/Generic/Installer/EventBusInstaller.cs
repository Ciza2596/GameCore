
using GameCore.Generic.Implement;
using GameCore.Generic.Infrastructure;
using MessagePipe;
using Zenject;


namespace GameCore.Generic.Installer
{
    public class EventBusInstaller : Installer<EventBusInstaller>
    {

        public override void InstallBindings()
        {
            var option = Container.BindMessagePipe();
            Container.BindMessageBroker<DomainEvent>(option);
            Container.Bind<IDomainEventBus>().To<DomainEventBus>().AsSingle();
        }
    }
}