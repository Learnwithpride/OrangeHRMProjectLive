using NUnit.Framework;
using OrangeHRMProjectJune.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class AddEmploymentStatusSteps
    {
        AddEmploymentStatusPage addEmploymentStatusPage;

        public AddEmploymentStatusSteps()
        {
            addEmploymentStatusPage = new AddEmploymentStatusPage();
        }



        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            addEmploymentStatusPage.NavigateToUrl(url);
        }
        
        [Given(@"I enter the admin username ""(.*)""")]
        public void GivenIEnterTheAdminUsername(string Username)
        {
            addEmploymentStatusPage.EnterUsername(Username); 
        }
        
        [Given(@"I enter the admin password ""(.*)""")]
        public void GivenIEnterTheAdminPassword(string Password)
        {
            addEmploymentStatusPage.EnterPassword(Password);
        }
        
        [Given(@"I click on the login button")]
        public void GivenIClickOnTheLoginButton()
        {
            addEmploymentStatusPage.ClickOnLoginButton();
        }
        
        [Given(@"I click on Admin")]
        public void GivenIClickOnAdmin()
        {
            addEmploymentStatusPage.ClickOnAdmin();
        }
        
        [Given(@"I click on Job")]
        public void GivenIClickOnJob()
        {
            addEmploymentStatusPage.ClickOnJob();
        }
        
        [Given(@"I click on Employment Status")]
        public void GivenIClickOnEmploymentStatus()
        {
            addEmploymentStatusPage.ClickEmploymentStatus();

        }
        
        [Given(@"I click on Add")]
        public void GivenIClickOnAdd()
        {
            addEmploymentStatusPage.ClickAddButton();

        }

        [Given(@"I enter Name ""(.*)""")]
        public void GivenIEnterName(string Name)
        {
            addEmploymentStatusPage.Entername(Name);
        }


        [When(@"I click on Save")]
        public void WhenIClickOnSave()
        {
            addEmploymentStatusPage.ClickSaveButton();
        }
        
        [When(@"I click on Okay")]
        public void WhenIClickOnOkay()
        {
            addEmploymentStatusPage.ClickOkay();
        }
        
        [Then(@"I confirm it has been successfully added")]
        public void ThenIConfirmItHasBeenSuccessfullyAdded()
        {
            Assert.That(addEmploymentStatusPage.IsDeleteButtonDisplayed);
        }

        [Then(@"I tick the checkbox beside the newly created employee")]
        public void ThenITickTheCheckboxBesideTheNewlyCreatedEmployee()
        {
            addEmploymentStatusPage.ClickCheckBox();
        }

        [Then(@"I click on delete")]
        public void ThenIClickOnDelete()
        {
            addEmploymentStatusPage.ClickDeleteButton();
        }
        
        [Then(@"I confirm Employment status has been successfully deleted")]
        public void ThenIConfirmEmploymentStatusHasBeenSuccessfullyDeleted()
        {
            Assert.That(addEmploymentStatusPage.EmploymentStatusSuccessfullyDeleted);
        }
    }
}
