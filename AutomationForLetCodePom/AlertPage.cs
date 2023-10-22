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
    public class AlertPage
    {
        static string PAGE_TITLE = "Alert";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/alert");
            Driver.Instance.Manage().Window.Maximize();
        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(),'Alert')]"));
                return titleElement.Text == PAGE_TITLE;

            }
        }


        static IWebElement acceptAlert => Driver.Instance.FindElement(By.Id("accept"));
        static IWebElement confirmAlert => Driver.Instance.FindElement(By.Id("confirm"));
        static IWebElement promptAlert => Driver.Instance.FindElement(By.Id("prompt"));
        static IWebElement modernAlert => Driver.Instance.FindElement(By.Id("modern"));

        public static void AcceptAlert()
        {
            try
            {
                acceptAlert.Click();
                Actions act = new Actions(Driver.Instance);
                acceptAlert.Click();
                act.SendKeys(Keys.Enter);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public static void CanConfirmAlertMessage()
        {
            try
            {
                confirmAlert.Click();
                Actions act = new Actions(Driver.Instance);
                confirmAlert.Click();
                act.SendKeys(Keys.ArrowRight);
                IAlert alert = Driver.Instance.SwitchTo().Alert();
                alert.Accept();
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }
        public static void SelectPromptAlert()
        {
            promptAlert.Click();
            Actions act = new Actions(Driver.Instance);
            promptAlert.Click();
            act.SendKeys("abc").Build().Perform();
        }
        public static void CanDismissSweetAlert(ref bool answer)
        {
            modernAlert.Click();
            Actions act = new Actions(Driver.Instance);
            act.SendKeys(Keys.Tab).Build().Perform();
            act.SendKeys(Keys.Enter).Build().Perform();
            var sweetAlert = Driver.Instance.FindElement(By.ClassName("modal-content"));
            answer = sweetAlert.Displayed;

        }


    }

}
