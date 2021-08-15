using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests
{
    [Binding]
    public class SellerCertificateSteps
    {
        [Given(@"I click on the Certifications tab")]
        public void GivenIClickOnTheCertificationsTab()
        {
            ProfilePage.ClickOnCertificationsTab(Driver.driver);
        }
        
        [Given(@"I click on the Add New button")]
        public void GivenIClickOnTheAddNewButton()
        {
            ProfilePage.ClickOnAddNewButtonForCertifications(Driver.driver);
        }
        
        [Given(@"I enter a Certificate or Award")]
        public void GivenIEnterACertificateOrAward()
        {
            ProfilePage.InputCertificate(Driver.driver);
        }
        
        [Given(@"I enter Certified From")]
        public void GivenIEnterCertifiedFrom()
        {
            ProfilePage.InputCertifiedFrom(Driver.driver);
        }
        
        [Given(@"I select the Year from drop down")]
        public void GivenISelectTheYearFromDropDown()
        {
            ProfilePage.ChooseCertificationYear(Driver.driver);
        }

        [When(@"I click on the Add button for certification")]
        public void WhenIClickOnTheAddButtonForCertification()
        {
            ProfilePage.ClickOnAddButtonForCertifications(Driver.driver);
        }

        [Then(@"the certification will be added")]
        public void ThenTheCertificationWillBeAdded()
        {
            ProfilePage.VerifyIfCertificationIsAdded();
        }

        [Given(@"I can see certificates in the profile")]
        public void GivenICanSeeCertificatesInTheProfile()
        {
            ProfilePage.VerifyIfCertificationTabIsNotEmpty(Driver.driver);
        }

        [Given(@"I click on the Certificate Edit icon")]
        public void GivenIClickOnTheCertificateEditIcon()
        {
            ProfilePage.ClickOnEditIconForCertificates(Driver.driver);
        }

        [Given(@"I edit certificate details")]
        public void GivenIEditCertificateDetails()
        {
            ProfilePage.EditCertificationRecord(Driver.driver);
        }

        [When(@"I click on the certificate Update button")]
        public void WhenIClickOnTheCertificateUpdateButton()
        {
            ProfilePage.ClickOnUpdateButtonForCertificate(Driver.driver);
        }

        [Then(@"the certificate will be updated")]
        public void ThenTheCertificateWillBeUpdated()
        {
            ProfilePage.VerifyIfCertificationIsUpdated();
        }

        [When(@"I click on the Certificate delete icon")]
        public void WhenIClickOnTheCertificateDeleteIcon()
        {
            ProfilePage.ClickOnDeleteIconForCertification(Driver.driver);
        }

        [Then(@"the certificate will be deleted")]
        public void ThenTheCertificateWillBeDeleted()
        {
            ProfilePage.VerifyIfCertificationIsDeleted();
        }

    }
}
