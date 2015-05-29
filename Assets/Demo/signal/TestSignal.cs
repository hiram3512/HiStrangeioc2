
using strange.extensions.signal.impl;
namespace Test
{
    public class StartSignal : Signal
    {
    }
    public class ClickSignal : Signal
    {
    }
    public class RequestSignal : Signal<string>
    { }
    public class FufillSignal : Signal
    { }
}