using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRM.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangeHRMProjectJune.PageObject
{
    class LoginLogout
    {
        public LoginLogout()
        {
            driver = BaseTest.driver;
        }

        IWebDriver driver;


        IWebElement Username => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@id='txtPassword']"));
        IWebElement Login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement Loggedin => driver.FindElement(By.XPath("//*[@id='welcome']"));
        IWebElement Picture => driver.FindElement(By.XPath("/html/body/div[1]/div[1]/a[2]"));
        IWebElement Logout => driver.FindElement(By.XPath("#welcome-menu > ul > li:nth-child(3)"));
        IWebElement LoggedOut => driver.FindElement(By.XPath("//a[text()='Forgot your password?']"));





        public void NavigateToUrl(string url)
        {

            driver.Navigate().GoToUrl(url);
                
        }
        
     
        public void ClickUsername()
        {
            Username.SendKeys("Admin");

        }
        
        public void EnterPassword()
        {
            Password.SendKeys("admin123");

        }
        
        public void ClickLogin()
        {
            Login.Click();

        }
        public void SuccessufullLoggedin()

        {
            Loggedin.Click();

        }

        public void ClickonProfilePicture()
        {
            Thread.Sleep(5000);
            Picture.Click();
           
           

        }
        public void ClickonLogout()
        {
            //    Actions actions = new Actions(driver);
            //    actions.MoveToElement(Logout);
            //    actions.Click();
           // Thread.Sleep(2000);
            Logout.Click();

        }
        public bool ClickonLoggedOutDisplayed()


        {

            return LoggedOut.Displayed;

        }



    }

    internal class Hooks1
    {
        internal static Iwebdriver driver;
    }

    internal class Iwebdriver
    {
        internal IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }
    }
}
