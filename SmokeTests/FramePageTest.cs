using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
   
    [TestClass]
    public class FramePageTest:TestFather
    {
      
        [TestMethod]
        public void Can_Enter_Frame_Page()
        {
            FramePage.GoTo();
            Assert.IsTrue(FramePage.IsAt, "Could not enter frame page");
        }
        [TestMethod]
        public void Can_Enter_Text_Into_First_Name_Box()
        {
            string text = "";
            FramePage.GoTo();
            FramePage.CanEnterTextIntoFirstNameBox(ref text);
            Assert.IsTrue(text == "abc", "Could not enter text into first name box");
        }
        [TestMethod]
        public void Can_Enter_Text_Into_Last_Name_Box()
        {
            string text = "";
            FramePage.GoTo();
            FramePage.CanEnterTextIntoLastNameBox(ref text);
            Assert.IsTrue(text == "abc", "Could not enter text into last name box");
        }
        [TestMethod]
        public void Can_Enter_Text_Into_Email_Box()
        {
            string text = "";
            FramePage.GoTo();
            FramePage.CanEnterTextIntoEmailBox(ref text);
            Assert.IsTrue(text == "abc", "Could not enter text into email box");
        }

    }
}
