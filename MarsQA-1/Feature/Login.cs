using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login
    {
        [Given(@"I go to the website")]
        public void GivenIGoToTheWebsite()
        {
            //SignIn.SigninStep();
            //Driver.NavigateUrl();
        }

        [Given(@"I click on the sign in button")]
        public void GivenIClickOnTheSignInButton()
        {
            //SignIn.Login();
        }

        [Given(@"I enter the login details")]
        public void GivenIEnterTheLoginDetails(Table table)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I am taken to the home page")]
        public void ThenIAmTakenToTheHomePage()
        {
            //ScenarioContext.Current.Pending();
        }
     


    }

}
