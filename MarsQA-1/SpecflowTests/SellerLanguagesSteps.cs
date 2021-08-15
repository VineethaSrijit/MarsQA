using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SellerLanguagesSteps
    {
        
        [Given(@"I am on the Profile page")]
        public void GivenIAmOnTheProfilePage()
        {
            HomePage.GoToProfilePage(Driver.driver);

        }

        [Given(@"I click on the Languages tab")]
        public void GivenIClickOnTheLanguagesTab()
        {
            ProfilePage.ClickOnLanguagesTab(Driver.driver);
        }

        [Given(@"I click on Add New button")]
        public void GivenIClickOnAddNewButton()
        {
            ProfilePage.ClickonAddNewLanguageButton(Driver.driver);
        }

        [Given(@"I enter a string to Language textbox")]
        public void GivenIEnterAStringToLanguageTextbox()
        {
            ProfilePage.InputLanguage(Driver.driver);
        }

        [Given(@"I choose from Language Level dropbox")]
        public void GivenIChooseFromLanguageLevelDropbox()
        {
            ProfilePage.ChooseLanguageLevel(Driver.driver);
        }

        [When(@"I click on the Add button")]
        public void WhenIClickOnTheAddButton()
        {
            ProfilePage.ClickOnAddButtonForLanguage(Driver.driver);
        }


        [Then(@"the language will be added")]
        public void ThenTheLanguageWillBeAdded()
        {

            ProfilePage.VerifyIfLanguageIsAdded();
        }

        [Given(@"I can see a language in the list")]
        public void GivenICanSeeALanguageInTheList()
        {
            ProfilePage.VerifyIfLanguageTabNotEmpty(Driver.driver);
        }

        [Given(@"I click on the Edit icon")]
        public void GivenIClickOnTheEditIcon()
        {
            ProfilePage.ClickOnEditIconForLanguage(Driver.driver);
        }

        [Given(@"the language row can be edited")]
        public void GivenTheLanguageRowCanBeEdited()
        {
            ProfilePage.EditLanguageRecord(Driver.driver);
        }

        [When(@"I click on the language Update button")]
        public void WhenIClickOnTheLanguageUpdateButton()
        {
            ProfilePage.ClickOnUpdateButtonForLanguage(Driver.driver);
        }

        [Then(@"the language row will be updated")]
        public void ThenTheLanguageRowWillBeUpdated()
        {
            ProfilePage.CheckIfLanguageIsUpdated();
        }

        [When(@"I click on the delete icon")]
        public void WhenIClickOnTheDeleteIcon()
        {
            ProfilePage.ClickonDeleteIconForLanguage(Driver.driver);
        }

        [Then(@"the language row will be deleted")]
        public void ThenTheLanguageRowWillBeDeleted()
        {
            ProfilePage.CheckIfLanguageIsDeleted();
        }

    }
}
