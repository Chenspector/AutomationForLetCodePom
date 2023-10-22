using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
    
    [TestClass]
    public class SelectablePageTest:TestFather
    {      
        [TestMethod]
        public void Can_Enter_Selectable()
        {
            SelectablePage.GoTo();
            Assert.IsTrue(SelectablePage.IsAt, "Could not enter selectable page");
        }
        [TestMethod]
        public void Can_Select_All_Elements()
        {
            bool answer = false;
            SelectablePage.GoTo();
            SelectablePage.SelectAllElements(ref answer);
            Assert.IsTrue(answer == true, "Could not select all elements");
        }
    }
}
