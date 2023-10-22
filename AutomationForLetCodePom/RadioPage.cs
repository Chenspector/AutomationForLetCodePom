using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class RadioPage
    {
        static string PAGE_TITLE = "Radio & Checkbox";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/radio");
            Driver.Instance.Manage().Window.Maximize();
        }

        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Radio & Checkbox')]"));
                return titleElement.Text == PAGE_TITLE;
            }

        }

        static IWebElement rememberCheckbox => Driver.Instance.FindElement(By.CssSelector("input[type='checkbox']"));

        public static void CanCheckIfCheckboxIsSelected(ref bool check)
        {
            try
            {
                check = rememberCheckbox.Selected;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
