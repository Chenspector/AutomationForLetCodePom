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
    public class SortPage
    {
        static string PAGE_TITLE = "Sort";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/sortable");
            Driver.Instance.Manage().Window.Maximize();


        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Sort')]"));
                return titleElement.Text == PAGE_TITLE;
            }

        }
        
        static List<IWebElement> actionsBtn => Driver.Instance.FindElements(By.Id("cdk-drop-list-0")).ToList();

        public static void CanMoveElementsToDone(ref bool listLength)
        {
            try
            {
                Driver.Instance.SwitchTo().DefaultContent();
                IWebElement listOne = Driver.Instance.FindElements(By.XPath("//div[contains(@class,'example-container')]"))[0];
                List<IWebElement> listOneElements = listOne.FindElements(By.Id("sample-box1")).ToList();
                IWebElement listTwo = Driver.Instance.FindElements(By.XPath("//div[contains(@class,'example-container')]"))[1];
                List<IWebElement> listTwoElements = listTwo.FindElements(By.Id("sample-box1")).ToList();

                Actions act = new Actions(Driver.Instance);
                for (int i = 0; i < listOneElements.Count; i++)
                {
                    var one = listOneElements[i];
                    for (int j = 0; j < listTwoElements.Count; j++)
                    {
                        var two = listTwoElements[j];
                        if (listOneElements.Count > 0)
                        {
                            act.ClickAndHold(one).MoveToElement(two).Release(two).Build().Perform();
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            break;
                        }

                    }

                }
                List<IWebElement> listOneElementsNow = listOne.FindElements(By.Id("sample-box1")).ToList();
                if (listOneElementsNow.Count == 0)
                {
                    listLength = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
