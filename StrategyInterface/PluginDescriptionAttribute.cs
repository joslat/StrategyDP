using System;

namespace StrategyInterface
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginDescriptionAttribute : System.Attribute
    {
        private string _PluginDescription;

        public PluginDescriptionAttribute(string pluginDescription) : base()
        {
            _PluginDescription = pluginDescription;
            return;
        }

        public override string ToString()
        {
            return _PluginDescription;
        }
    }
}
