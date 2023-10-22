using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
  
    [TestClass]
    public class DropPageTest:TestFather
    {
      
        [TestMethod]
        public void Can_Enter_Drop_Page()
        {
            DropPage.GoTo();
            Assert.IsTrue(DropPage.IsAt, "Could not enter Drop Page");
        }
        [TestMethod]
        public void Can_Drag_Square_To_Target()
        {
            string text = "";
            DropPage.GoTo();
            DropPage.CanDragSquareToTarget(ref text);
            Assert.IsTrue(text == "293px", "Could not enter ");
        }
    }
}
