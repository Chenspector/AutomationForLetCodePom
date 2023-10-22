using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationForLetCodePom
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }


        public static void Initialize()
        {
            Instance = new ChromeDriver();
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
   
}