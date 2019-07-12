using StrategyInterface;
using System;

namespace TFT.Generic
{
    [PluginDisplayName("TFT.Generic")]
    [PluginDescription("This Plugin strategy is for handling Generic TFT Displays")]
    public sealed class TFTComponentManager : ITrainHardwareComponentManagerStrategy
    {
        void ITrainHardwareComponentManagerStrategy.Connect(string ip)
        {
            Console.WriteLine("Hey I am responsible to Manage the TFT Display units in a generic way..");
        }
    }
}
