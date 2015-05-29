
using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;
namespace Test
{
    public class StartCommand : Command
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }
        public override void Execute()
        {
            GameObject test = new GameObject("test");
            Debug.Log("do");
            test.transform.SetParent(contextView.transform);
        }
    }
}