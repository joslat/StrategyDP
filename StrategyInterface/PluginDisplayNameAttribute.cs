using System;

namespace StrategyInterface
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginDisplayNameAttribute : System.Attribute
    {
        private string _displayName;

        public PluginDisplayNameAttribute(string DisplayName) : base()
        {
            _displayName = DisplayName;
            return;
        }

        public override string ToString()
        {
            return _displayName;
        }
    }
}
