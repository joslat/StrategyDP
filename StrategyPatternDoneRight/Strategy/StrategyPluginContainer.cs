using System;
using StrategyInterface;

namespace StrategyPatternDoneRight.Strategy
{
    public class StrategyPluginContainer
    {
        private System.Type _type;
        private ITrainHardwareComponentManagerStrategy _instance;
        public ITrainHardwareComponentManagerStrategy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = (ITrainHardwareComponentManagerStrategy)Activator.CreateInstance(_type);

                return _instance;
            }
        }
        public string DisplayName
        {
            get { return _type.GetCustomAttributes(typeof(PluginDisplayNameAttribute), false)[0].ToString(); }
        }

        public string Description
        {
            get { return _type.GetCustomAttributes(typeof(PluginDescriptionAttribute), false)[0].ToString(); }
        }

        public StrategyPluginContainer(System.Type type) : base()
        {
            _type = type;
            _instance = (ITrainHardwareComponentManagerStrategy)Activator.CreateInstance(_type);

            return;
        }
    }
}
