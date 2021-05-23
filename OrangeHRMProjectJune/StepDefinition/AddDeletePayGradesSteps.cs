using System;
using TechTalk.SpecFlow;
using OrangeHRM.PageObject;
using System.Threading;
using NUnit.Framework;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class AddDeletePayGradesSteps
    {
        AddDeletePayGrades addDeletePayGrades;

        public AddDeletePayGradesSteps()
        {
            addDeletePayGrades = new AddDeletePayGrades();
        }



        [Given(@"that I navigate to ""(.*)""")]
        public void GivenThatINavigateTo(string url)
        {
            addDeletePayGrades.NavigateToUrl(url);
        }


        [Given(@"the user enter admin username ""(.*)""")]
        public void GivenTheUserEnterAdminUsername(string Username)
        {
            addDeletePayGrades.EnterUsername(Username);
        }

        [Given(@"the user enter admin password ""(.*)""")]
        public void GivenTheUserEnterAdminPassword(string Password)
        {
            addDeletePayGrades.EnterPassword(Password);
        }


        [Given(@"the user clicks the orange login button")]
        public void GivenTheUserClicksTheOrangeLoginButton()
        {
            addDeletePayGrades.ClickOnLoginButton();
        }

        [Given(@"the user clicks on admin tab")]
        public void GivenTheUserClicksOnAdminTab()
        {
            addDeletePayGrades.ClickOnAdmin();
        }

        [Given(@"the user clicks on the job drop down list")]
        public void GivenTheUserClicksOnTheJobDropDownList()
        {
            addDeletePayGrades.ClickOnJob();
        }

        [Given(@"the user clicks on Pay Grades")]
        public void GivenTheUserClicksOnPayGrades()
        {
            addDeletePayGrades.ClickOnPayGrades();
        }

        [Given(@"the user clicks on the green Add tab")]
        public void GivenTheUserClicksOnTheGreenAddTab()
        {
            addDeletePayGrades.ClickOnAddTab();
        }

        [Given(@"the user enters name ""(.*)""")]
        public void GivenTheUserEntersName(string Paygradename)
        {
            addDeletePayGrades.EnterName(Paygradename);
        }

        [Given(@"the user clicks on the save button")]
        public void GivenTheUserClicksOnTheSaveButton()
        {
            addDeletePayGrades.ClickOnSave();
        }

        [Given(@"the user clicks on the Add button")]
        public void GivenTheUserClicksOnTheAddButton()
        {
            addDeletePayGrades.ClickOnAdd();
        }

        [Given(@"the user enters currency details ""(.*)""")]
        public void GivenTheUserEntersCurrencyDetails(string USD)
        {
            addDeletePayGrades.EnterCurrency(USD);
        }

        [When(@"the user clicks on save")]
        public void WhenTheUserClicksOnSave()
        {
            addDeletePayGrades.ClickOnSaveTab();
        }

        [Then(@"user paygrade should be added successfully")]
        public void ThenUserPaygradeShouldBeAddedSuccessfully()
        {
            Assert.That(addDeletePayGrades.IsValidCurrencyDisplayed);
        }

        [When(@"the user clicks on admin tab")]
        public void WhenTheUserClicksOnAdminTab()
        {
            addDeletePayGrades.ClickOnAdminTab();
        }

        [When(@"the user clicks on the job drop down list")]
        public void WhenTheUserClicksOnTheJobDropDownList()
        {
            addDeletePayGrades.ClickOnJobDropdown();
        }

        [When(@"the user clicks on Pay Grades")]
        public void WhenTheUserClicksOnPayGrades()
        {
            addDeletePayGrades.ClickOnPayGradesOption();
        }

        [When(@"the user click in the radio button for fefe")]
        public void WhenTheUserClickInTheRadioButtonForFefe()
        {
            addDeletePayGrades.SelectPaygrade();
        }

        [When(@"the user clicks on the red Delete tab")]
        public void WhenTheUserClicksOnTheRedDeleteTab()
        {
            addDeletePayGrades.ClickOnDelete();
        }

        [When(@"the user clicks on the green OK button")]
        public void WhenTheUserClicksOnTheGreenOKButton()
        {
            addDeletePayGrades.ClickOnOKButton();
        }

        [Then(@"the pay grade should be successfully deleted")]
        public void ThenThePayGradeShouldBeSuccessfullyDeleted()
        {
            Assert.That(addDeletePayGrades.IsPaygradesPageDisplayed);
        }
    }
}