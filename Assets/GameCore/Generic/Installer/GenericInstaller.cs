using GameCore.Generic.Implement.Derived;
using GameCore.Generic.Infrastructure;
using Zenject;


namespace GameCore.Generic.Installer
{
    public class GenericInstaller : Installer<GenericInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ITimeProvider>().To<TimeProvider>().AsSingle().IfNotBound();
            Container.Bind(typeof(ITimerSystem) , typeof(ITickable)).To<TimerSystem>().AsSingle().IfNotBound();
            Container.BindTickableExecutionOrder<TimerSystem>(-100).IfNotBound();
        }
    }
}