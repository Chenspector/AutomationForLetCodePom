using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationForLetCodePom
{
    public class HomePage
    {
        static string PAGE_TITLE = "Work-Space";

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://letcode.in/test");
            Thread.Sleep(5000);
            Driver.Instance.Manage().Window.Maximize();
        }
        public static bool IsAt
        {

            get
            {
                var titleElement = Driver.Instance.FindElement(By.Id("testing"));
                return titleElement.Text == PAGE_TITLE;
            }

        }


        static IWebElement editLink => Driver.Instance.FindElement(By.CssSelector("a[href='/edit']"));
        static IWebElement buttonLink => Driver.Instance.FindElement(By.CssSelector("a[href='/buttons']"));
        static IWebElement selectLink => Driver.Instance.FindElement(By.CssSelector("a[href='/dropdowns']"));
        static IWebElement alertLink => Driver.Instance.FindElement(By.CssSelector("a[href='/alert']"));

        static IWebElement frameLink => Driver.Instance.FindElement(By.CssSelector("a[href='/frame']"));
        static IWebElement radioLink => Driver.Instance.FindElement(By.CssSelector("a[href='/radio']"));
        static IWebElement windowLink => Driver.Instance.FindElement(By.CssSelector("a[href='/windows']"));
        static IWebElement elementsLink => Driver.Instance.FindElement(By.CssSelector("a[href='/elements']"));

        static IWebElement dragLink => Driver.Instance.FindElement(By.CssSelector("a[href='/draggable']"));
        static IWebElement dropLink => Driver.Instance.FindElement(By.CssSelector("a[href='/dropable']"));
        static IWebElement sortLink => Driver.Instance.FindElement(By.CssSelector("a[href='/sortable']"));
        static IWebElement selectableLink => Driver.Instance.FindElement(By.CssSelector("a[href='/selectable']"));

        static IWebElement sliderLink => Driver.Instance.FindElement(By.CssSelector("//a[href='/slider']"));
        static IWebElement tableLink => Driver.Instance.FindElement(By.CssSelector("//a[href='/table']"));
        static IWebElement adTableLink => Driver.Instance.FindElement(By.CssSelector("//a[href='/advancedtable']"));
        static IWebElement calendarLink => Driver.Instance.FindElement(By.CssSelector("//a[href='/calendar']"));



        //Think about checking such action for any of the links
        public static void CanEnterInputPage(ref string url)
        {
            editLink.Click();
            url = Driver.Instance.Url;
        }


    }
}
