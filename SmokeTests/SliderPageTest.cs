using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
    /// <summary>
    /// Summary description for SliderPageTest
    /// </summary>
    [TestClass]
    public class SliderPageTest:TestFather
    {
       
        [TestMethod]
        public void CanEnterSliderPage()
        {
            SliderPage.GoTo();
            Assert.IsTrue(SliderPage.IsAt, "Could not enter slider page");
        }
        [TestMethod]
        public void Can_Move_Slider_Right()
        {
            int value = 0;
            SliderPage.GoTo();
            SliderPage.CanMoveSliderRight(ref value);
            Assert.IsTrue(value > 10, "Could not move slider right");

        }
        [TestMethod]
        public void CanMoveSliderLeft()
        {
            int value = 0;
            SliderPage.GoTo();
            SliderPage.CanMoveSliderLeft(ref value);
            Assert.IsTrue(value < 10, "Could not move slider left");
        }
    }
}
