using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class SliderPage
    {
        static string PAGE_TITLE = "Slider";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/slider");
            Driver.Instance.Manage().Window.Maximize();

        }

        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Slider')]"));
                return titleElement.Text == PAGE_TITLE;

            }

        }


        static IWebElement slider => Driver.Instance.FindElement(By.Id("generate"));

        public static void CanMoveSliderRight(ref int value)
        {
            try
            {
                slider.Click();
                slider.SendKeys(Keys.ArrowRight);
                Driver.Instance.SwitchTo().DefaultContent();
                IWebElement getCountries = Driver.Instance.FindElement(By.XPath("//button[contains(@class, 'is-primary')]"));
                IWebElement wordLimit = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Word limit')]"));
                string rawText = wordLimit.Text;
                string lastWord = rawText.Split(' ').Last();
                value = Convert.ToInt32(lastWord);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        public static void CanMoveSliderLeft(ref int value)
        {
            try
            {
                Actions act = new Actions(Driver.Instance);
                act.ContextClick(slider).Perform();
                act.SendKeys(Keys.Escape).Build().Perform();
                slider.SendKeys(Keys.ArrowLeft);
                Driver.Instance.SwitchTo().DefaultContent();
                IWebElement getCountries = Driver.Instance.FindElement(By.XPath("//button[contains(@class, 'is-primary')]"));
                IWebElement wordLimit = Driver.Instance.FindElement(By.XPath("//h1[contains(text(), 'Word limit')]"));
                string rawText = wordLimit.Text;
                string lastWord = rawText.Split(' ').Last();
                value = Convert.ToInt32(lastWord);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
