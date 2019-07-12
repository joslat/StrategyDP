using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using StrategyInterface;

namespace StrategyPatternDoneRight.Strategy
{
    public class StrategyPluginLoader
    {
        private List<StrategyPluginContainer> _plugins;
        public List<StrategyPluginContainer> Plugins
        {
            get { return _plugins; }
            set { _plugins = value; }
        }
        public StrategyPluginLoader()
        {
            _plugins = new List<StrategyPluginContainer>();
            LoadPlugins();
        }

        public void LoadPlugins()
        {
            string[] files = Directory.GetFiles(@"D:\jola\Plugins\netstandard2.0", "*.dll");

            foreach (string pluginFile in files)
            {
                try
                {
                    Assembly a = Assembly.LoadFrom(pluginFile);
                    System.Type[] types = a.GetTypes();
                    foreach (System.Type type in types)
                    {
                        if (type.GetInterface("ITrainHardwareComponentManagerStrategy") != null)
                        {
                            if (type.GetCustomAttributes(typeof(PluginDisplayNameAttribute),
                                    false).Length != 1)
                                throw new PluginNotValidException(type,
                                    "PlugDisplayNameAttribute is not supported");
                            if (type.GetCustomAttributes(typeof(PluginDescriptionAttribute),
                                    false).Length != 1)
                                throw new PluginNotValidException(type,
                                    "PlugDescriptionAttribute is not supported");

                            StrategyPluginContainer SPC = new StrategyPluginContainer(type);

                            // Check if the plugin is already there... if so, we remove and re-add it... 
                            // this is due as if we have a folder where we are listening (FilesystemWatcher) for possible additions of dlls
                            // we could get a new version...
                            var plugin = Plugins.Where(p => p.DisplayName == SPC.DisplayName);
                            bool PluginAlreadyLoaded = plugin.Any();
                            if (PluginAlreadyLoaded)
                            {
                                Plugins.Remove(plugin.FirstOrDefault());
                            }
                            Plugins.Add(SPC); // This way the plugin is always up to date.
                        }
                    }
                }
                catch (Exception e)

                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
