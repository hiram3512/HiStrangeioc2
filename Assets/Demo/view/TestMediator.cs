

using UnityEngine;
using strange.extensions.mediation.impl;
namespace Test
{
    public class TestMediator : Mediator
    {
        [Inject]
        public TestView view { get; set; }

        public override void OnRegister()
        {
            view.signal_Click.AddListener(OnClick);
        }
        public void OnClick()
        {
            Debug.Log("button clicked");
        }
    }
}