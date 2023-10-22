using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class InputPage
    {
        static string PAGE_TITLE = "Input";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/edit");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            //var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("hiddenElementId")));
            Thread.Sleep(5000);
            Driver.Instance.Manage().Window.Maximize();
        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(),'Input')]"));
                return titleElement.Text == PAGE_TITLE;
            }
        }

       

        static IWebElement fullNameTxt => Driver.Instance.FindElement(By.Id("fullName"));
        static IWebElement appendTxt => Driver.Instance.FindElement(By.Id("join"));
        static IWebElement getTxt => Driver.Instance.FindElement(By.Id("getMe"));
        static IWebElement ClearTxt => Driver.Instance.FindElement(By.Id("clearMe"));
        static IWebElement NoEditTxt => Driver.Instance.FindElement(By.Id("noEdit"));
        static IWebElement downTxt => Driver.Instance.FindElement(By.Id("dontwrite"));

      

        public static void EnterTextIntoTextbox(ref string text)
        {
            try
            {
                fullNameTxt.SendKeys("abc");
                text = fullNameTxt.GetAttribute("value");
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }
        public static void HighlightTextboxText(ref string textFirst, ref string textLast)
        {
            try
            {
                Actions action = new Actions(Driver.Instance);
                appendTxt.Click();
                action.SendKeys(Keys.Home).Build().Perform();
                textFirst = appendTxt.GetAttribute("value");
                int length = textFirst.Length;
                action.KeyDown(Keys.LeftShift).Build().Perform();
                for (int i = 0; i < length; i++)
                {
                    action.SendKeys(Keys.ArrowRight).Build().Perform();
                }
                action.KeyDown(Keys.LeftShift);
                action.SendKeys(Keys.Backspace).Build().Perform();
                textLast = appendTxt.GetAttribute("value");
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public static void CheckIfTextboxIsDisabled(ref bool answer)
        {
            try
            {
                answer = NoEditTxt.Enabled;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void CanCheckIfTextboxIsReadOnly(ref string text)
        {
            try
            {
                Actions action = new Actions(Driver.Instance);
                downTxt.Click();
                action.SendKeys(Keys.Backspace).Build().Perform();
                text = downTxt.GetAttribute("value");
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
