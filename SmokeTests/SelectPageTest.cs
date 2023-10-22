using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
    [TestClass]
    public class SelectPageTest:TestFather
    {    
        [TestMethod]
        public void TestMethod1()
        {
            SelectPage.GoTo();
            Assert.IsTrue(SelectPage.IsAt, "Could not enter select page");
        }
        //Maybe write here all my test plans
        [TestMethod]
        public void Can_Select_Apple_From_Dropdown()
        {
            string text = "";
            SelectPage.GoTo();
            SelectPage.CanSelectAppleFromDropdown(ref text);
            Assert.IsTrue(text == "Apple", "Could not select apple from dropdown");
        }
        [TestMethod]
        public void Can_Select_Last_Dropdown_Value_By_Index()
        {
            int num = 0;
            string selection = "";
            SelectPage.GoTo();
            SelectPage.CanSelectValueByIndexFromDropdown(ref selection);
            Assert.IsTrue(selection.Contains("X-Men"), "Could not select last dropdown value");


        }
    }
}
