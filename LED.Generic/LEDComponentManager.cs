using System;
using StrategyInterface;

namespace LED.Generic
{
    [PluginDisplayName("LED.Generic")]
    [PluginDescription("This Plugin strategy is for handling Generic LED displays")]
    public class LEDComponentManager : ITrainHardwareComponentManagerStrategy
    {
        void ITrainHardwareComponentManagerStrategy.Connect(string ip)
        {
            Console.WriteLine("Hey I am responsible to Manage the LED Display units in a generic way..");
        }
    }
}
