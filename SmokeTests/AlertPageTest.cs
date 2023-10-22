using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
   
    [TestClass]
    public class AlertPageTest:TestFather
    {       
        [TestMethod]
        public void Can_Enter_Alert_Page()
        {
            AlertPage.GoTo();
            Assert.IsTrue(AlertPage.IsAt, "Could not enter alert page");
            
        }
        [TestMethod]
        public void Can_Accept_Alert()
        {
            AlertPage.GoTo();
            AlertPage.AcceptAlert();
        }
        [TestMethod]
        public void Can_confirm_Alert_Message()
        {
            AlertPage.GoTo();
            AlertPage.CanConfirmAlertMessage();
        }
        [TestMethod]
        public void Can_Select_Prompt_Alert()
        {
            AlertPage.GoTo();
            AlertPage.SelectPromptAlert();
        }
        [TestMethod]
        public void Can_Dismiss_Sweet_Alert()
        {
            bool answer = true;
            AlertPage.GoTo();
            AlertPage.CanDismissSweetAlert(ref answer);
            Assert.IsTrue(answer == false, "Could not dismiss sweet alert");
        }
    }
}
