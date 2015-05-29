




using strange.extensions.context.impl;
namespace Test
{
    public class TestRoot : ContextView
    {
        void Start()
        {
            context = new TestContext(this);
        }
    }
}