using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class DragPage
    {
        static string PAGE_TITLE = "Drag";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/draggable");
            Driver.Instance.Manage().Window.Maximize();
        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(),'Drag')]"));
                return titleElement.Text == PAGE_TITLE;
            }
        }



        static IWebElement dragBtn => Driver.Instance.FindElement(By.Id("sample-box"));
        static IWebElement card => Driver.Instance.FindElement(By.ClassName("card-header"));

        

        public static void CanDragSquareInsideBox(ref string text)
        {
            try
            {
                Actions act = new Actions(Driver.Instance);
                act.ClickAndHold(dragBtn).MoveToElement(card).Release(card).Build().Perform();
                string elementStyle = dragBtn.GetAttribute("style");
                text = elementStyle.Substring(23, 5);
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        public static void CanDragByOffset(ref string text)
        {
            try
            {
                //not working properly
                int x = dragBtn.Location.X;
                int y = dragBtn.Location.Y;
                Actions act = new Actions(Driver.Instance);
                act.DragAndDropToOffset(dragBtn, x + 0, y + 5).Build().Perform();
                string elementStyle = dragBtn.GetAttribute("style");
                text = elementStyle.Substring(23, 5);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
