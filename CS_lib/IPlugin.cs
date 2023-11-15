﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public interface IPlugin
    {
        string PluginsName { get; }
        string Version { get; }
        string Description { get; }
        int Run(int input1, int input2);
    }
}
