using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace AutomationForLetCodePom
{
    public class SelectPage
    {
        static string PAGE_TITLE = "Dropdown";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/dropdowns");
            Driver.Instance.Manage().Window.Maximize();
        }
        public static bool IsAt
        {
            get
            {
                var titleElement = Driver.Instance.FindElement(By.XPath("//h1[contains(text(),'Dropdown')]"));
                return titleElement.Text == PAGE_TITLE;

            }

        }

        static IWebElement dropDownFruits => Driver.Instance.FindElement(By.Id("fruits"));
        static IWebElement dropdownHeros => Driver.Instance.FindElement(By.Id("superheros"));
        static IWebElement dropdownHerosSelection => Driver.Instance.FindElement(By.ClassName("subtitle"));
        static IWebElement dropdownProLanguage => Driver.Instance.FindElement(By.Id("lang"));
        static IWebElement dropdownCountries => Driver.Instance.FindElement(By.Id("country"));

        

        public static void CanSelectAppleFromDropdown(ref string text)
        {
            try
            {
                SelectElement select = new SelectElement(dropDownFruits);
                bool a = select.IsMultiple;
                IList<IWebElement> elementCount = select.Options;
                select.SelectByText("Apple");
                text = select.SelectedOption.Text;
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }
        public static void CanSelectValueByIndexFromDropdown(ref string selection)
        {
            try
            {
                SelectElement select = new SelectElement(dropdownHeros);
                int index = select.Options.Count;
                select.SelectByIndex(index - 1);
                selection = dropdownHerosSelection.Text;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
    

}
