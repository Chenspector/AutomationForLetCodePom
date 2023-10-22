using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
   
    [TestClass]
    public class InputPageTest:TestFather
    {      
        [TestMethod]
        public void Can_Enter_Input_Page()
        {
            InputPage.GoTo();
            Assert.IsTrue(InputPage.IsAt, "Could not enter input page");
        }
        [TestMethod]
        public void Can_Enter_Text_Into_Textbox()
        {
            string text = "";
            InputPage.GoTo();
            InputPage.EnterTextIntoTextbox(ref text);
            Assert.IsTrue(text == "abc", "Could not enter text into textbox");
        }
        [TestMethod]
        public void Can_Highlight_Textbox_Text()
        {
            string textFirst = "";
            string textLast = "";
            InputPage.GoTo();
            InputPage.HighlightTextboxText(ref textFirst, ref textLast);
            Assert.IsTrue(textLast == "", "Could not highlight textbox text");
        }
        [TestMethod]
        public void Can_Check_If_Textbox_Is_Disabled()
        {
            bool answer = true;
            InputPage.GoTo();
            InputPage.CheckIfTextboxIsDisabled(ref answer);
            Assert.IsTrue(answer == false, "Textbox is not disabled");
        }
        [TestMethod]
        public void Can_Check_If_Textbox_Is_Read_Only()
        {
            string text = "";
            InputPage.GoTo();
            InputPage.CanCheckIfTextboxIsReadOnly(ref text);
            Assert.IsTrue(text == "This text is readonly", "Textbox is not read only");
        }
    }
}
