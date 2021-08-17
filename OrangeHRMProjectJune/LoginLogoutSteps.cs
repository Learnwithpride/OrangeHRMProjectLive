using System;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune
{
    [Binding]
    public class LoginLogoutSteps
    {
        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
