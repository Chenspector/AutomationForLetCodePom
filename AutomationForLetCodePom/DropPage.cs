using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class DropPage
    {
        static string PAGE_TITLE = "Drop";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/dropable");
            Driver.Instance.Manage().Window.Maximize();

        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Drop')]"));
                return titleElement.Text == PAGE_TITLE;
            }

        }
        
        static IWebElement dragBtn => Driver.Instance.FindElement(By.Id("draggable"));
        static IWebElement dropSqrTxt => Driver.Instance.FindElement(By.Id("droppable"));
        static IWebElement dropTxt => dropSqrTxt.FindElement(By.XPath("//a[text()='Dropped!']"));

        public static void CanDragSquareToTarget(ref string text)
        {
            try
            {
                Actions act = new Actions(Driver.Instance);
                act.ClickAndHold(dragBtn).MoveToElement(dropSqrTxt).Release(dropSqrTxt).Build().Perform();
                string style = dragBtn.GetAttribute("style");
                text = style.Substring(37, 5);
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
