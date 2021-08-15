using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests
{
    [Binding]
    public class SellerEducationSteps
    {
        [Given(@"I click on the Education tab")]
        public void GivenIClickOnTheEducationTab()
        {
            ProfilePage.ClickOnEducationTab(Driver.driver);
        }

        [Given(@"I click on the Add New button for Education")]
        public void GivenIClickOnTheAddNewButtonForEducation()
        {
            ProfilePage.ClickOnAddNewButtonForEducation(Driver.driver);
        }

        [Given(@"I enter a College or University Name")]
        public void GivenIEnterACollegeOrUniversityName()
        {
            ProfilePage.InputCollegeOrUniversity(Driver.driver);
        }
        
        [Given(@"I select from Country drop down")]
        public void GivenISelectFromCountryDropDown()
        {
            ProfilePage.ChooseCountry(Driver.driver);
        }
        
        [Given(@"I select the from Title drop down")]
        public void GivenISelectTheFromTitleDropDown()
        {
            ProfilePage.ChooseFromTitleDropDown(Driver.driver);
        }
        
        [Given(@"I enter a Degree")]
        public void GivenIEnterADegree()
        {
            ProfilePage.InputDegree(Driver.driver);
        }
        
        [Given(@"I select from Year drop down")]
        public void GivenISelectFromYearDropDown()
        {
            ProfilePage.ChooseYearOfGraduation(Driver.driver);
        }
        
        [When(@"I click on the Add button for education")]
        public void WhenIClickOnTheAddButtonForEducation()
        {
            ProfilePage.ClickOnAddButtonForEducation(Driver.driver);
        }
        
        [Then(@"the education will be added")]
        public void ThenTheEducationWillBeAdded()
        {
            ProfilePage.VerifyIfEducationIsAdded();
        }

        [Given(@"I can see education added to the profile")]
        public void GivenICanSeeEducationAddedToTheProfile()
        {
            ProfilePage.VerifyIfEducationTabIsNotEmpty(Driver.driver, "Edit");
        }

        [Given(@"I click on the edit icon for Education")]
        public void GivenIClickOnTheEditIconForEducation()
        {
            ProfilePage.ClickOnEditIconForEducation(Driver.driver);
        }

        [Given(@"I edit the education details")]
        public void GivenIEditTheEducationDetails()
        {
            ProfilePage.EditEducationRecord(Driver.driver);
        }

        [When(@"I click on the Update button for education")]
        public void WhenIClickOnTheUpdateButtonForEducation()
        {
            ProfilePage.ClickonUpdateButtonForEducation(Driver.driver);
        }

        [Then(@"the education will be updated")]
        public void ThenTheEducationWillBeUpdated()
        {
            ProfilePage.VerifyIfEducationIsUpdated();
        }

        [Given(@"I can see education record available for deleting")]
        public void GivenICanSeeEducationRecordAvailableForDeleting()
        {
            ProfilePage.VerifyIfEducationTabIsNotEmpty(Driver.driver,"Delete");
        }

        [When(@"I click on the remove icon for Education")]
        public void WhenIClickOnTheRemoveIconForEducation()
        {
            ProfilePage.ClickOnDeleteIconForEducation(Driver.driver);
        }

        [Then(@"the education will be deleted")]
        public void ThenTheEducationWillBeDeleted()
        {
            ProfilePage.VerifyIfEducationIsDeleted();
        }


    }
}
