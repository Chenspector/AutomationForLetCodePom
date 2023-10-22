using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
    /// <summary>
    /// Summary description for HomePageTest
    /// </summary>
    [TestClass]
    public class HomePageTest:TestFather
    {
        [TestMethod]
        public void Can_Enter_Home_Page()
        {
            HomePage.GoTo();
            Assert.IsTrue(HomePage.IsAt, "Could not enter home page");
        }
        [TestMethod]
        public void Can_Enter_Input_Page()
        {
            string url = "";
            HomePage.GoTo();
            HomePage.CanEnterInputPage(ref url);
            Assert.IsTrue(url == "https://letcode.in/edit", "Could not enter input page");
        }
        
    }
}
