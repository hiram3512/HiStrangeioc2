

using UnityEngine;
using strange.extensions.command.impl;
namespace Test
{
    public class RequestCommand : Command
    {
        [Inject]
        public IService service { get; set; }
        public override void Execute()
        {
            Retain();
            service.signal_Fulfill.AddListener(OnComplete);
            service.Request();
        }
        void OnComplete()
        {
            service.signal_Fulfill.RemoveListener(OnComplete);
            Debug.Log("get data finish");

            Release();
        }

    }
}