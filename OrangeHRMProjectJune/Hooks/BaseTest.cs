using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace OrangeHRM.Hooks
{
    [Binding]
    public class BaseTest
    {

        public static IWebDriver driver;


        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("start-maximized");
            //options.AddArgument("--disable-gpu");
            //options.AddArgument("--headless");
            ////options.AddArgument("--incognito");
            
            //new DriverManager().SetUpDriver(new ChromeConfig());
            //Console.WriteLine("Setup");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}
