using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class ElementsPage
    {
        static string PAGE_TITLE = "Elements";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/elements");
            Driver.Instance.Manage().Window.Maximize();
        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Elements')]"));
                return titleElement.Text == PAGE_TITLE;
            }

        }

        static IWebElement gitTxtbox => Driver.Instance.FindElement(By.Name("username"));
        static IWebElement searchBtn => Driver.Instance.FindElement(By.Id("search"));

        public static void CanSearchForGithubUser(ref string userName, ref bool elementExists)
        {
            try
            {
                gitTxtbox.SendKeys(userName);
                searchBtn.Click();
                Thread.Sleep(5000);
                var userImg = Driver.Instance.FindElement(By.ClassName("media-left"));
                elementExists = userImg.Displayed;

            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public static void CanListAllUserRepos(ref List<string> list)
        {
            try
            {
                list = Driver.Instance.FindElements(By.CssSelector("a[href*='https://github.com']")).Select(iw => iw.Text).ToList();

            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
