
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
namespace Test
{
    public class TestView : View
    {
        public ClickSignal signal_Click = new ClickSignal();
        void OnGUI()
        {
            if (GUI.Button(new Rect(0, 0, 100, 40), "click"))
            {
                signal_Click.Dispatch();
            }
        }
    }
}