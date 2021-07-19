using OpenQA.Selenium;
using OrangeHRM.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangeHRMProjectJune.PageObject
{
    class AddEmploymentStatusPage
    {
        public AddEmploymentStatusPage()
        {
            driver = BaseTest.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//*[@id='txtUsername']"));

        IWebElement password => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement admin => driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']"));

        IWebElement job => driver.FindElement(By.XPath("//*[@id='menu_admin_Job']"));

        IWebElement employmentStatus => driver.FindElement(By.XPath("//*[@id='menu_admin_employmentStatus']"));

        IWebElement addButton => driver.FindElement(By.XPath("//*[@id='btnAdd']"));

        IWebElement enterName => driver.FindElement(By.XPath("//*[@id='empStatus_name']"));

        IWebElement save => driver.FindElement(By.XPath("//*[@id='btnSave']"));

        IWebElement delete => driver.FindElement(By.XPath("//*[@id='btnDelete']"));

        IWebElement checkBox => driver.FindElement(By.XPath("//*[@id='resultTable']/tbody/tr[1]/td[1]"));

        IWebElement deleteButton => driver.FindElement(By.XPath("//*[@id='btnDelete']"));

        IWebElement okay => driver.FindElement(By.XPath("//*[@id='dialogDeleteBtn']"));



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

        public void ClickEmploymentStatus()
        {
            employmentStatus.Click();
        }

        public void ClickAddButton()
        {
            addButton.Click();

        }

        public void Entername(string Name)
        {
            enterName.SendKeys(Name);
        }

        public void ClickSaveButton()
        {
            save.Click();
        }

        public bool IsDeleteButtonDisplayed()
        {
            return delete.Displayed;
        }

        public void ClickCheckBox()
        {
            checkBox.Click();
        }

        public void ClickDeleteButton()
        {
            deleteButton.Click();
        }

        public void ClickOkay()
        {
            okay.Click();
        }

        public bool EmploymentStatusSuccessfullyDeleted()
        {
            return delete.Displayed;
        }





    }
}
