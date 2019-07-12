using System;
using StrategyInterface;

namespace RCOM.Generic
{
    [PluginDisplayName("RCOM.Generic")]
    [PluginDescription("This Plugin strategy is for handling Generic RCOM communication devices")]
    public class RCOMComponentManager : ITrainHardwareComponentManagerStrategy
    {
        void ITrainHardwareComponentManagerStrategy.Connect(string ip)
        {
            Console.WriteLine("Hey I am responsible to Manage the RCOM units in a generic way..");
        }
    }
}
