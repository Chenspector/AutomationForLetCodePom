using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class FramePage
    {
        static string PAGE_TITLE = "Frame";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/frame");
            Driver.Instance.Manage().Window.Maximize();

        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(),'Frame')]"));
                return titleElement.Text == PAGE_TITLE;

            }

        }

        static IWebElement firstNameTxt => Driver.Instance.FindElement(By.CssSelector("input[name='fname']"));
        static IWebElement lastNameTxt => Driver.Instance.FindElement(By.CssSelector("input[name='lname']"));
        static IWebElement emailTxt => Driver.Instance.FindElement(By.CssSelector("input[name='email']"));
        static IWebElement emailFrame => Driver.Instance.FindElement(By.XPath("//iframe[@src='innerFrame']"));


        public static void CanEnterTextIntoFirstNameBox(ref string text)
        {
            try
            {
                Driver.Instance.SwitchTo().Frame(0);
                firstNameTxt.Click();
                firstNameTxt.SendKeys("abc");
                text = firstNameTxt.GetAttribute("value");
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public static void CanEnterTextIntoLastNameBox(ref string text)
        {
            try
            {
                Driver.Instance.SwitchTo().Frame(0);
                lastNameTxt.Click();
                lastNameTxt.SendKeys("abc");
                text = lastNameTxt.GetAttribute("value");
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public static void CanEnterTextIntoEmailBox(ref string text)
        {
            try
            {
                Driver.Instance.SwitchTo().Frame(0);
                Driver.Instance.SwitchTo().Frame(emailFrame);
                emailTxt.Click();
                emailTxt.SendKeys("abc");
                text = emailTxt.GetAttribute("value");
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
