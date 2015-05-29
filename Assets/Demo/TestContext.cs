


using UnityEngine;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.extensions.command.api;
using strange.extensions.command.impl;
namespace Test
{
    public class TestContext : MVCSContext
    {
        public TestContext(MonoBehaviour view)
            : base(view)
        {
        }
        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>();
            injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
        }
        override public IContext Start()
        {
            base.Start();
            StartSignal startSignal = (StartSignal)injectionBinder.GetInstance<StartSignal>();
            startSignal.Dispatch();
            return this;
        }
        protected override void mapBindings()
        {
            commandBinder.Bind<StartSignal>().To<StartCommand>().Once();
        }
    }
}