using NUnit.Framework;
using OrangeHRMProjectJune.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class AddSkillSteps
    {
        AddSkillPage addSkillPage;

        public AddSkillSteps()
        {
            addSkillPage = new AddSkillPage();
        }


        //[Given(@"That I Navigate to https://opensource-demo\.orangehrmlive\.com/")]
        //public void GivenThatINavigateToHttpsOpensource_Demo_Orangehrmlive_Com(string Url)
        //{
        //    addSkillSteps.GivenThatINavigateToHttpsOpensource_Demo_Orangehrmlive_Com(Url)
        //}
        
        //[Given(@"I enter Username")]
        //public void GivenIEnterUsername()
        //{
        //    addSkillSteps.GivenIEnterUsername();
        //}
        
        //[Given(@"I enter  Password")]
        //public void GivenIEnterPassword()
        //{
        //    addSkillSteps.GivenIEnterPassword();
        //}
        
        //[Given(@"I enter Login")]
        //public void GivenIEnterLogin()
        //{
        //    addSkillSteps.GivenIEnterLogin();
        //}
        
        [Given(@"I CLick on Admin")]
        public void GivenICLickOnAdmin()
        {
            addSkillPage.ClickonAdmin();
        }
        
        [Given(@"I Click on Qualifications")]
        public void GivenIClickOnQualifications()
        {
            Thread.Sleep(2000);
            addSkillPage.ClickonQualifications();
        }
        
        [Given(@"I  Click on Skills")]
        public void GivenIClickOnSkills()
        {
            addSkillPage.ClickonSkills();
        }

        [Given(@"I Click on Add")]
        public void GivenIClickOnAdd()
        {
            addSkillPage.ClickonAdd();
        }

        [Given(@"I enter the Skill Name ""(.*)""")]
        public void GivenIEnterTheSkillName(string skillname)
        {
            addSkillPage.EnterSkillname(skillname);
        }


        [Given(@"I enter Description")]
        public void GivenIEnterDescription()
        {
            addSkillPage.EnterDescription();
        }

        [When(@"I clicks on the Save button")]
        public void WhenIClicksOnTheSaveButton()
        {
            addSkillPage.ClickonSavebutton();
        }

        [Then(@"I Confirm the Skill as been succesfully added")]
        public void ThenIConfirmTheSkillAsBeenSuccesfullyAdded()
        {
            Assert.That(addSkillPage.IsSkillSuccessfullyAdded);
        }

        [Then(@"I Tick the checkbox beside the skill you created")]
        public void ThenITickTheCheckboxBesideTheSkillYouCreated()
        {
            addSkillPage.TickTheCheckBox();
        }


        [When(@"I Click on Delete")]
        public void WhenIClickOnDelete()
        {
            addSkillPage.ClickOnDelete();
        }
        
        [Then(@"I should confirm Skill as been successfully deleted")]
        public void ThenIShouldConfirmSkillAsBeenSuccessfullyDeleted()
        {

            Assert.That(addSkillPage.SuccessufullyDeleted);
                
                
        }
    }
}
