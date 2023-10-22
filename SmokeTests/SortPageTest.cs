using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
   
    [TestClass]
    public class SortPageTest:TestFather
    {        
        [TestMethod]
        public void Can_Enter_Sort_Page()
        {
            SortPage.GoTo();
            Assert.IsTrue(SortPage.IsAt, "Could not enter Sort page");
        }
        [TestMethod]
        public void Can_Move_All_Elements_From_To_Do_To_Done()
        {
            bool listLength = false;
            SortPage.GoTo();
            SortPage.CanMoveElementsToDone(ref listLength);
            Assert.IsTrue(listLength == true, "Could not move all elemenys from to do to done");
        }
    }
}
