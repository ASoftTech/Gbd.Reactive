﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp1.Logging;

namespace TestApp1 {
    public class MyClass {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public void DoSomething() {
            Logger.Trace("Method 'DoSomething' in progress");
        }
    }
}
