using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
    
    [TestClass]
    public class DragPageTest:TestFather
    {
        [TestMethod]
        public void Can_Enter_Drag_Page()
        {
            DragPage.GoTo();
            Assert.IsTrue(DragPage.IsAt, "Could not enter drag page");
        }
        [TestMethod]
        public void Can_Drag_Square_To_Other_Side_Of_Box()
        {
            string text = "";
            DragPage.GoTo();
            DragPage.CanDragSquareInsideBox(ref text);
            Assert.IsTrue(text == "198px", "Could not drag square to other side of box");
        }
        [TestMethod]
        public void Can_Drag_Square_By_Offset()
        {
            string text = "";
            DragPage.GoTo();
            DragPage.CanDragByOffset(ref text);

        }

    }
}
