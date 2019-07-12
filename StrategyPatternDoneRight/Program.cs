using System;
using StrategyPatternDoneRight.Strategy;

namespace StrategyPatternDoneRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Implement the Strategy Design Pattern!");
            Strategy.StrategyPluginLoader SRP = new StrategyPluginLoader();
            
            // We load all the plugins
            SRP.LoadPlugins();

            // we iterate through them and execute the connect command
            foreach (var plugin in SRP.Plugins)
            {
                Console.WriteLine("about to execute the plugin: " + plugin.DisplayName);
                plugin.Instance.Connect("127.0.0.1"); // the ip does nothing here
            }

            Console.WriteLine("And that's it! (please enter to exit)");
            Console.ReadLine();
        }
    }
}
