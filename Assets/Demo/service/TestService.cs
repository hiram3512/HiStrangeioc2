





using UnityEngine;
using System.Collections;
using strange.extensions.context.api;
namespace Test
{
    public class TestService : IService
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }
        [Inject]
        public FufillSignal signal_Fulfill { get; set; }

        public void Request()
        {
            contextView.GetComponent<MonoBehaviour>().StartCoroutine(Wait());
        }
        /// <summary>
        /// 模拟网络请求延迟1秒
        /// </summary>
        /// <returns></returns>
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(1);
            signal_Fulfill.Dispatch();
        }
    }
}