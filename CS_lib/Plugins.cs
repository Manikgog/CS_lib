using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public class Plugins : IPluginFactory
    {
        public int PluginsCount { get; }
        public string[] GetPluginNames { get; }
        public Plugins()
        {
            PluginsCount = 4;
            GetPluginNames =
                new string[4] { 
                "Addition",
                "Substraction",
                "Multiplication",
                "Division"
                };
        }
        public IPlugin GetPlugin(string pluginName)
        {
            
            if (pluginName.Equals("Addition"))
            {
                IPlugin iplugin = new Addition();
                return iplugin;
            }else if (pluginName.Equals("Substraction"))
            {
                IPlugin iplugin = new Substraction();
                return iplugin;
            }else if (pluginName.Equals("Multiplication"))
            {
                IPlugin iplugin = new Multiplication();
                return iplugin;
            }else if(pluginName.Equals("Division"))
            {
                IPlugin iplugin = new Division();
                return iplugin;
            }
           return null;

        }

        internal class Addition : IPlugin
        {
            public string PluginsName { get; }
            public string Version { get; }
            public string Description { get; }
            public Addition()
            {
                PluginsName = "Addition";
                Version = "1.0";
                Description = "Сложение двух чисел.";
            }
            
            public int Run(int input1, int input2)
            {
                return input1 + input2;
            }
        }

        internal class Substraction : IPlugin
        {
            public string PluginsName { get; }
            public string Version { get; }
            public string Description { get; }
            public Substraction()
            {
                PluginsName = "Substraction";
                Version = "1.0";
                Description = "Вычитание двух чисел.";
            }

            public int Run(int input1, int input2)
            {
                return input1 - input2;
            }
        }

        internal class Multiplication : IPlugin
        {
            public string PluginsName { get; }
            public string Version { get; }
            public string Description { get; }
            public Multiplication()
            {
                PluginsName = "Multiplication";
                Version = "1.0";
                Description = "Умножение двух чисел.";
            }

            public int Run(int input1, int input2)
            {
                return input1 * input2;
            }
        }

        internal class Division : IPlugin
        {
            public string PluginsName { get; }
            public string Version { get; }
            public string Description { get; }
            public Division()
            {
                PluginsName = "Division";
                Version = "1.0";
                Description = "Деление двух чисел.";
            }

            public int Run(int input1, int input2)
            {
                return input1 / input2;
            }
        }
    }
}
