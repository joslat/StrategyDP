using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyInterface
{
    public class PluginNotValidException : System.Exception
    {
        public PluginNotValidException(System.Type type, string Message) : base("The plug-in " + type.Name + " is not valid\n" + Message)
        {
            return;
        }
    }
}
