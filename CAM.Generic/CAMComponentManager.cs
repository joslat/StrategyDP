using StrategyInterface;
using System;

namespace CAM.Generic
{
    [PluginDisplayName("CAM.Generic")]
    [PluginDescription("This Plugin strategy is for handling Generic Cameras")]
    public sealed class CAMComponentManager : ITrainHardwareComponentManagerStrategy
    {
        void ITrainHardwareComponentManagerStrategy.Connect(string ip)
        {
            Console.WriteLine("Hey I am responsible to Manage the Train Network Camera units in a generic way..");
        }
    }
}
