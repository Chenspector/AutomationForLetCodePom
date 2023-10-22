using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
    
    [TestClass]
    public class TestFather
    {     
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        [TestCleanup]
        public void Close()
        {
            Driver.Close();
        }
    }
}
