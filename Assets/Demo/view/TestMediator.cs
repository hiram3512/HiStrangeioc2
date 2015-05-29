

using UnityEngine;
using strange.extensions.mediation.impl;
namespace Test
{
    public class TestMediator : Mediator
    {
        [Inject]
        public TestView view { get; set; }

        [Inject]
        public RequestSignal signal_Request { get; set; }

        public override void OnRegister()
        {
            view.signal_Click.AddListener(OnClick);
        }
        public void OnClick()
        {
            signal_Request.Dispatch("www.baidu.com");
        }
    }
}