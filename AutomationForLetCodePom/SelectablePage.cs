using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class SelectablePage
    {
        static string PAGE_TITLE = "Selectable";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/selectable");
            Driver.Instance.Manage().Window.Maximize();

        }

        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Selectable')]"));
                return titleElement.Text == PAGE_TITLE;

            }

        }

       

        static List<IWebElement> eleList => Driver.Instance.FindElements(By.ClassName("ui-selectable")).ToList();

        public static void SelectAllElements(ref bool answer)
        {
            try
            {
                for (int i = 0; i < eleList.Count; i++)
                {
                    var ele = eleList[i];
                    Actions act = new Actions(Driver.Instance);
                    act.KeyDown(Keys.Control).Build().Perform();
                    ele.Click();
                    Thread.Sleep(2000);
                }

                List<IWebElement> eleListTwo = Driver.Instance.FindElements(By.XPath("//div[contains(@class, 'ui-selected')]")).ToList();
                if (eleListTwo.Count == 9)
                {
                    answer = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
