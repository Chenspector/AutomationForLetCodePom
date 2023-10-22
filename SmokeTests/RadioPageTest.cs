using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{

    [TestClass]
    public class RadioPageTest:TestFather
    {       
        [TestMethod]
        public void Can_Enter_Radio_Page()
        {
            RadioPage.GoTo();
            Assert.IsTrue(RadioPage.IsAt, "Can not enter radio page");
        }
        [TestMethod]
        public void Can_Check_If_Checkbox_Is_Selected()
        {
            bool check = false;
            RadioPage.GoTo();
            RadioPage.CanCheckIfCheckboxIsSelected(ref check);
            Assert.IsTrue(check == true, "Checkbox is not selected");

        }
    }
}
