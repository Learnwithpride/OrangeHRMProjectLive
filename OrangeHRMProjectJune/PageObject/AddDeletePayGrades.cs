using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangeHRM.PageObject
{
    public class AddDeletePayGrades
    {
        public AddDeletePayGrades()
        {
            driver = BaseTest.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//*[@id='txtUsername']"));

        IWebElement password => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement admin => driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']"));

        IWebElement job => driver.FindElement(By.XPath("//*[@id='menu_admin_Job']"));

        IWebElement payGrades => driver.FindElement(By.XPath("//*[@id='menu_admin_viewPayGrades']"));

        IWebElement add => driver.FindElement(By.XPath("//*[@id='btnAdd']"));

        IWebElement enterName => driver.FindElement(By.XPath("//*[@id='payGrade_name']"));

        IWebElement save => driver.FindElement(By.XPath("//*[@id='btnSave']"));

        IWebElement addCurrency => driver.FindElement(By.XPath("//*[@id='btnAddCurrency']"));

        IWebElement enterCurrency => driver.FindElement(By.XPath("//*[@id='payGradeCurrency_currencyName']"));

        IWebElement saveCurrency => driver.FindElement(By.XPath("//*[@id='btnSaveCurrency']"));

        IWebElement isUsDollarDisplayed => driver.FindElement(By.XPath("//a[text()='United States Dollar']"));

        IWebElement adminTab => driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']"));

        IWebElement jobDropdown => driver.FindElement(By.XPath("//*[@id='menu_admin_Job']"));

        IWebElement payGradesOption => driver.FindElement(By.XPath("//*[@id='menu_admin_viewPayGrades']"));

        // add code for scenario- And the user click in the radio button for fefe78
        IWebElement selectFefe78 => driver.FindElement(By.XPath("(//input[@type='checkbox'])[7]"));

        IWebElement delete => driver.FindElement(By.XPath("//input[@id='btnDelete']"));

        IWebElement ok => driver.FindElement(By.XPath("//input[@id='dialogDeleteBtn']"));

        IWebElement payGradesPage => driver.FindElement(By.XPath("//*[@id='search-results']/div[1]/h1"));
        
        //testing



        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterUsername(string Username)
        {
            username.SendKeys(Username);
        }

        public void EnterPassword(string Password)
        {
            password.SendKeys(Password);
        }

        public void ClickOnLoginButton()
        {
            login.Click();
        }

        public void ClickOnAdmin()
        {
            admin.Click();
        }

        public void ClickOnJob()
        {
            job.Click();
        }

        public void ClickOnPayGrades()
        {
            payGrades.Click();
        }

        public void ClickOnAddTab()
        {
            add.Click();
        }

        public void EnterName(string Paygradename)
        {
            enterName.SendKeys(Paygradename);
        }

        public void ClickOnSave()
        {
            save.Click();
        }

        public void ClickOnAdd()
        {
            addCurrency.Click();
        }

        public void EnterCurrency(string USD)
        {
            enterCurrency.SendKeys(USD);
        }

        public void ClickOnSaveTab()
        {
            saveCurrency.Click();
        }

        public bool IsValidCurrencyDisplayed()
        {
            return isUsDollarDisplayed.Displayed;
        }

        public void ClickOnAdminTab()
        {
            adminTab.Click();
        }

        public void ClickOnJobDropdown()
        {
            jobDropdown.Click();
        }

        public void ClickOnPayGradesOption()
        {
            payGradesOption.Click();
        }

        // add method for scenario- And the user click in the radio button for fefe78
        public void SelectPaygrade()
        {
            //SelectElement select = new SelectElement(selectFefe78);
            //select.SelectByValue("7");
            selectFefe78.Click();

        }

        public void ClickOnDelete()
        {
            delete.Click();
        }

        public void ClickOnOKButton()
        {
            ok.Click();
        }

        public bool IsPaygradesPageDisplayed()
        {
            return payGradesPage.Displayed;
        }
    }
}

