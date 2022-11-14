﻿using NUnit.Framework.Internal.Execution;
using PageObjectModelTest.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTest.Helper
{
    public class Base
    {

        [SetUp]
        public static void BeforeScenario()
        {
            WebDriver.Initialization();
        }

        [TearDown]
        public static void AfterScenario()
        {
            WebDriver.CleanUp();
        }
        
        
    }
}
