using NUnit.Framework;
using OrangeHRMProjectJune.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class LoginLogoutSteps
    {

      LoginLogout loginLogout;
        

        public LoginLogoutSteps()
    {
        loginLogout = new LoginLogout();
    }




        //[Given(@"I navigate to website\(https://opensource-demo\.orangehrmlive\.com/index\.php/auth/login")]

        //public void GivenINavigateToWebsiteHttpsOpensource_Demo_Orangehrmlive_ComIndex_PhpAuthLogin()
        //{
        //    ScenarioContext.Current.Pending();
        //}



        [Given(@"the user navigate to website ""(.*)""")]
        public void GivenTheUserNavigateToWebsite(string url)
        {
            loginLogout.NavigateToUrl(url);
        }

        [Given(@"the user enter Username")]
        public void GivenTheUserEnterUsername()
        {
            loginLogout.ClickUsername();
        }

        [Given(@"the user enter Password")]
        public void GivenTheUserEnterPassword()
        {
           loginLogout.EnterPassword();
        }

        [Given(@"the user click on Login")]
        public void GivenTheUserClickOnLogin()
        {
            loginLogout.ClickLogin();
        }

        [Given(@"the confirm successfull Logged in")]
        public void GivenTheConfirmSuccessfullLoggedIn()
        {
            loginLogout.SuccessufullLoggedin();
        }

        [Given(@"the click on Profile Picture")]
        public void GivenTheClickOnProfilePicture()
        {
            
            loginLogout.ClickonProfilePicture();
            
        }

        [When(@"the click on Logout")]
        public void WhenTheClickOnLogout()
        {
            
            loginLogout.ClickonLogout();
        }

        [When(@"I click on logout")]
        public void WhenIClickOnLogout()
        {
            Thread.Sleep(5000);
            loginLogout.ClickonLogout();
        }


        [Then(@"I should successfully be Logged Out")]
        public void ThenIShouldSuccessfullyBeLoggedOut()
        {
            Assert.That(loginLogout.ClickonLoggedOutDisplayed);
        }




    }
}
