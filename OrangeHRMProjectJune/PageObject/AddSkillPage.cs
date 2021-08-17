using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRM.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMProjectJune.PageObject
{
    class AddSkillPage
    {
        public AddSkillPage()
        {
            driver = BaseTest.driver;
        }

        IWebDriver driver;

        //IWebElement Username => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        //IWebElement Password => driver.FindElement(By.XPath("//*[@id='divPassword']/span"));
        //IWebElement Login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement Admin => driver.FindElement(By.CssSelector("#menu_admin_viewAdminModule"));
        IWebElement Qualifications => driver.FindElement(By.XPath("//a[text()='Qualifications']"));
        IWebElement Skills => driver.FindElement(By.XPath("//a[text()='Skills']"));
        IWebElement Add => driver.FindElement(By.XPath("//*[@id='btnAdd']"));
        IWebElement Skillname => driver.FindElement(By.XPath("//*[@id='skill_name']"));
        IWebElement Description => driver.FindElement(By.XPath("//*[@id='skill_description']"));
        IWebElement Savebutton => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement successfullyadded => driver.FindElement(By.XPath("//*[@id='recordsListTable']/thead/tr/th[2]"));
        IWebElement tickthecheckbox => driver.FindElement(By.XPath("//*[@id='recordsListTable']/tbody/tr[10]/td[1]/input"));
        IWebElement ClickonDelete => driver.FindElement(By.XPath("//*[@id='btnDel']"));
        IWebElement SuccesssfullyDeleted => driver.FindElement(By.XPath("//*[@id='mainMenuFirstLevelUnorderedList']/li[1]/ul"));









        //public void NavigateToUrl

        //{

        //}

        //public void EnterUsername()
        //{
        //    Username.SendKeys("Admin");

        //}


        //public void EnterPassword()
        //{
        //    Password.SendKeys("admin123");

        //}

        //public void EnterLogin()
        //{
        //    Login.Click();
        //}

        public void ClickonAdmin()
        {
            Admin.Click();

        }

        public void ClickonQualifications()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(Qualifications);
            action.Click();
            action.Perform();


            //Qualifications.Click();
            

        }

        public void ClickonSkills()
        {
            Skills.Click();

        }

        public void ClickonAdd()
        {
            Add.Click();
        }

        public void EnterSkillname(string skillname)
        {
            Skillname.SendKeys(skillname);
        }

        public void EnterDescription()
        {

            Description.SendKeys("Changes");
        
        }
        
          
        

        public void ClickonSavebutton()
        {
            Savebutton.Click();
        }

        public bool IsSkillSuccessfullyAdded()
        {
            return successfullyadded.Displayed;
        }

        public void TickTheCheckBox()
        {
           tickthecheckbox.Click();

        }

        public void ClickOnDelete()
        {
            ClickonDelete.Click();

        }
        public bool SuccessufullyDeleted()
        {
            return SuccesssfullyDeleted.Displayed;
        }






        //  public void TickCheckbox()
        // {
        //     Add.
    }

       // public void ClickonDelete()
       // {
       //     Add.Click();
       // }






    }















