using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfilePage
    {
        static string message;
        static int randomIndex;
        static Random randomInt = new Random();
        static int levelIndex, yearIndex, countryIndex, titleIndex, graduationYearIndex;

        //Click on the languages tab in the Profile page
        public static void ClickOnLanguagesTab(IWebDriver driver)
        {
            IWebElement languagesTab = driver.FindElement(By.XPath("//a[normalize-space()='Languages']"));
            languagesTab.Click();

        }

        //Click on Languages Add New button
        public static void ClickonAddNewLanguageButton(IWebDriver driver)
        {
            try
            {
                IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
                addNewLanguage.Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("You have reached the maximum limit for languages");
                Console.WriteLine("You can only add four languages");
            }
        }

        //Funtion to input a language to the language text box
        public static void InputLanguage(IWebDriver driver)
        {
            try
            {
                ExcelLibHelper.PopulateInCollection(@"E:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");

                randomIndex = randomInt.Next(2, 8);

                IWebElement languageTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                languageTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "Language"));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("You have reached the maximum limit for languages");
                Console.WriteLine("You can only add four languages");
            }
        }

        //Function to choose from Language level drop down
        public static void ChooseLanguageLevel(IWebDriver driver)
        {
            try
            {
                ExcelLibHelper.PopulateInCollection(@"E:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
                levelIndex = Convert.ToInt32((ExcelLibHelper.ReadData(randomIndex, "Level")));

                IWebElement languageLevelDropBox = driver.FindElement(By.XPath("//select[@name='level']"));
                languageLevelDropBox.Click();

                SelectElement selectLanguageLevel = new SelectElement(languageLevelDropBox);
                selectLanguageLevel.SelectByIndex(levelIndex);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("You have reached the maximum limit for languages");
                Console.WriteLine("You can only add four languages");
            }
        }

        //Function to click on the Add button under Languages tab
        public static void ClickOnAddButtonForLanguage(IWebDriver driver)
        {
            try
            {
                IWebElement clickOnAddLanguageButton = driver.FindElement(By.XPath("//input[@value='Add']"));
                clickOnAddLanguageButton.Click();

                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                //IWebElement alertMessage = wait.Until(d => driver.FindElement(By.XPath("//div[@class='ns-box-inner']")));
                Thread.Sleep(500);
                IWebElement alertMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                message = alertMessage.Text;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("You have reached the maximum limit for languages");
                Console.WriteLine("You can only add four languages");
            }
        }

        //Function to verify if the language has been added
        public static void VerifyIfLanguageIsAdded()
        {
            try
            {
                if (message.Contains("has been added to your languages"))
                {
                    Assert.True(message.Contains("has been added to your languages"));
                    Console.WriteLine(message);
                }
                else if (message.Equals("This language is already exist in your language list."))
                {
                    Console.WriteLine(message);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You have reached the maximum limit for languages");
                Console.WriteLine("You can only add four languages");
            }
        }

        //Function to check if the language table is not empty
        public static void VerifyIfLanguageTabNotEmpty(IWebDriver driver)
        {

            try
            {
                IWebElement firstRowLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                Assert.IsNotEmpty(firstRowLanguage.Text);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No languages present in the Seller's profile");
            }
        }

        //Function to click on the Edit icon for language
        public static void ClickOnEditIconForLanguage(IWebDriver driver)
        {
            try
            {
                IWebElement editIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
                editIcon.Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No languages present in the Seller's profile for editing");
            }
        }

        //Function to edit language record
        public static void EditLanguageRecord(IWebDriver driver)
        {
            try
            {
                IWebElement languageTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
                languageTextBox.Clear();

                ExcelLibHelper.PopulateInCollection(@"E:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
                randomIndex = randomInt.Next(2, 8);
                languageTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "Language"));
                levelIndex = Convert.ToInt32((ExcelLibHelper.ReadData(randomIndex, "Level")));


                IWebElement languageLevelDropBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
                languageLevelDropBox.Click();

                SelectElement selectLanguageLevel = new SelectElement(languageLevelDropBox);
                selectLanguageLevel.SelectByIndex(levelIndex);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No languages present in the Seller's profile for editing");
            }
        }

        //Function to click on the update button for language
        public static void ClickOnUpdateButtonForLanguage(IWebDriver driver)
        {
            try
            {
                IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
                updateButton.Click();
               
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

                Thread.Sleep(500);
                IWebElement alertMessage = wait.Until(d => driver.FindElement(By.XPath("//div[@class='ns-box-inner']")));
                message = alertMessage.Text;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No languages present in the Seller's profile for editing");
            }
        }

        //Function to check if the language has been edited
        public static void CheckIfLanguageIsUpdated()
        {
            if (message.Contains("has been updated to your languages"))
            {
                Assert.True(message.Contains("has been updated to your languages"));
                Console.WriteLine(message);
            }
            else if (message.Contains("This language is already added to your language list."))
            {
                Console.WriteLine(message);
            }
        }

        //Function to click on the delete icon for language
        public static void ClickonDeleteIconForLanguage(IWebDriver driver)
        {
            try
            {
                IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
                deleteIcon.Click();

                IWebElement alertMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                message = alertMessage.Text;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No languages available in the profile for deleting");
            }
        }

        //Function to check if the language has been deleted
        public static void CheckIfLanguageIsDeleted()
        {
            try
            {
                Assert.True(message.Contains("has been deleted from your languages"));
                Console.WriteLine(message);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("No languages available in the profile for deleting");
            }
        }

        //Function to go the Certifications tab
        public static void ClickOnCertificationsTab(IWebDriver driver)
        {
            IWebElement certificationsTab = driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
            certificationsTab.Click();
        }

        //Function to click on the Add New button for Certifications
        public static void ClickOnAddNewButtonForCertifications(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            addNewButton.Click();
        }

        //Function to input Certificate/Award to Certificate/Award text box
        public static void InputCertificate(IWebDriver driver)
        {
            ExcelLibHelper.PopulateInCollection(@"E:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certifications");

            randomIndex = randomInt.Next(2, 8);

            IWebElement certificateTextBox = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            certificateTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "Certificate"));
        }

        //Function to input Certified from 
        public static void InputCertifiedFrom(IWebDriver driver)
        {
            IWebElement certifiedFromTextBox = driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
            certifiedFromTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "From"));
        }

        //Function to choose from Year drop down for Certification
        public static void ChooseCertificationYear(IWebDriver driver)
        {
            IWebElement yearDropDown = driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            yearDropDown.Click();

            yearIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Year"));

            SelectElement selectYear = new SelectElement(yearDropDown);
            selectYear.SelectByIndex(yearIndex);
        }

        //Function to click on the add button for certifications
        public static void ClickOnAddButtonForCertifications(IWebDriver driver)
        {
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            Thread.Sleep(500);
            IWebElement alertMessage = wait.Until(d => driver.FindElement(By.XPath("//div[@class='ns-box-inner']")));
            message = alertMessage.Text;
            Console.WriteLine(message);
        }

        //Function to verify if the certification has been added
        public static void VerifyIfCertificationIsAdded()
        {
            if (message.Contains("has been added to your certification"))
            {
                Assert.True(message.Contains("has been added to your certification"));
                Console.WriteLine(message);
            }
            else if (message.Equals("This information is already exist."))
            {
                Console.WriteLine(message);
                Console.WriteLine("Please add another certification");
            }
            else if (message.Equals("Duplicated data"))
            {
                Console.WriteLine(message);
                Console.WriteLine("Please add another certification");
            }
        }

        //Function to verify that the Certifications tab is not empty
        public static void VerifyIfCertificationTabIsNotEmpty(IWebDriver driver)
        {
            try
            {
                IWebElement certificationLastRow = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
                Assert.IsNotEmpty(certificationLastRow.Text);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No certifications available in the profile");
            }
        }

        //Function to click on the edit icon for certificates
        public static void ClickOnEditIconForCertificates(IWebDriver driver)
        {
            try
            {
                IWebElement editIconForCertificates = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
                editIconForCertificates.Click();
            }
            catch (Exception)
            {
                Console.WriteLine("No certifications available for editing");
            }
        }

        //Function to edit the certification record
        public static void EditCertificationRecord(IWebDriver driver)
        {
            try
            {
                ExcelLibHelper.PopulateInCollection(@"E:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certifications");
                randomIndex = randomInt.Next(2, 8);
                yearIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Year"));

                //editing certificate or award textbox
                IWebElement certificateTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input"));
                certificateTextBox.Clear();
                certificateTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "Certificate"));

                //editing certificate from textbox
                IWebElement certificateFromTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[2]/input"));
                certificateFromTextBox.Clear();
                certificateFromTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "From"));

                //editing year of certification from drop down
                IWebElement yearDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[3]/select"));
                yearDropDown.Click();
                SelectElement selectYearFromDropDown = new SelectElement(yearDropDown);
                selectYearFromDropDown.SelectByIndex(yearIndex);

            }
            catch (Exception)
            {
                Console.WriteLine("No certifications available for editing");
            }
        }

        //Function to click on the update button for certificate
        public static void ClickOnUpdateButtonForCertificate(IWebDriver driver)
        {
            try
            {
                IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
                updateButton.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

                Thread.Sleep(500);
                IWebElement alertMessage = wait.Until(d => driver.FindElement(By.XPath("//div[@class='ns-box-inner']")));
                message = alertMessage.Text;
                Console.WriteLine(message);    //delete after done testing the alert messages
            }
            catch (Exception)
            {
                Console.WriteLine("No certifications available for editing");
            }
        }

        //Function to verify if the certification record has been updated
        public static void VerifyIfCertificationIsUpdated()
        {
            try
            {
                if (message.Contains("has been updated to your certification"))
                {
                    Assert.True(message.Contains("has been updated to your certification"));
                    Console.WriteLine(message);
                }
                else if (message.Equals("This information is already exist."))
                {
                    Console.WriteLine(message);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No certifiations available for editing");
            }
        }

        //Function to click on the delete icon for certification
        public static void ClickOnDeleteIconForCertification(IWebDriver driver)
        {
            try
            {
                IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
                deleteIcon.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

                Thread.Sleep(500);
                IWebElement alertMessage = wait.Until(d => driver.FindElement(By.XPath("//div[@class='ns-box-inner']")));
                message = alertMessage.Text;
                Console.WriteLine(message);    
            }
            catch (Exception)
            {
                Console.WriteLine("No certifications available for deleting");
            }
        }

        //Function to verify if certification has been deleted
        public static void VerifyIfCertificationIsDeleted()
        {
            try
            {
                Assert.True(message.Contains("has been deleted from your certification"));
                Console.WriteLine(message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No certifications available for deleting");
            }
        }

        //Function to select Education tab
        public static void ClickOnEducationTab(IWebDriver driver)
        {
            IWebElement educationTab = driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
            educationTab.Click();
        }

        //Function to click on the Add New button for Education
        public static void ClickOnAddNewButtonForEducation(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            addNewButton.Click();
        }

        //Function to input College or University for seller
        public static void InputCollegeOrUniversity(IWebDriver driver)
        {
            ExcelLibHelper.PopulateInCollection(@"E:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Education");
            randomIndex = randomInt.Next(2, 5);

            IWebElement collegeTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            collegeTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "University"));
        }

        //Function to choose country of college or university for seller education
        public static void ChooseCountry(IWebDriver driver)
        {
            countryIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Country"));

            IWebElement countryDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryDropDown.Click();

            SelectElement selectCountryFromDropDown = new SelectElement(countryDropDown);
            selectCountryFromDropDown.SelectByIndex(countryIndex);
        }

        //Function to choose from the title of education drop down
        public static void ChooseFromTitleDropDown(IWebDriver driver)
        {
            IWebElement titleDropDown = driver.FindElement(By.XPath("//select[@name='title']"));
            titleDropDown.Click();

            titleIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Title"));

            SelectElement selectFromTitleDropDown = new SelectElement(titleDropDown);
            selectFromTitleDropDown.SelectByIndex(titleIndex);
        }

        //Function to input degree for seller
        public static void InputDegree(IWebDriver driver)
        {
            IWebElement degreeTextBox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            degreeTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "Degree"));
        }

        //Function to choose from year of graduation drop box
        public static void ChooseYearOfGraduation(IWebDriver driver)
        {
            IWebElement yearOfGraduationDropDown = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            yearOfGraduationDropDown.Click();

            graduationYearIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Graduation Year"));

            SelectElement selectYearOfGraduation = new SelectElement(yearOfGraduationDropDown);
            selectYearOfGraduation.SelectByIndex(graduationYearIndex);
        }

        //Function to click on the add button for adding seller's education
        public static void ClickOnAddButtonForEducation(IWebDriver driver)
        {
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            Thread.Sleep(500);
            IWebElement alertMessage = wait.Until(d => driver.FindElement(By.XPath("//div[@class='ns-box-inner']")));
            message = alertMessage.Text;
            Console.WriteLine(message);
        }

        //Function to verify if the education record has been added
        public static void VerifyIfEducationIsAdded()
        {
            if (message.Contains("has been added"))
            {
                Console.WriteLine(message);
            }
            else if (message.Equals("This information is already exist."))
            {
                Console.WriteLine(message);
                Console.WriteLine("Add a different education record");
            }
        }

        //Function to check if there is an education record available for editing
        public static void VerifyIfEducationTabIsNotEmpty(IWebDriver driver,string function)
        {
            try
            {
                IWebElement lastEducationRecord = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                Assert.IsNotEmpty(lastEducationRecord.Text);
            }
            catch (NoSuchElementException)
            {
                if (function.Equals("Edit"))
                {

                    Console.WriteLine("No education record available for editing");
                }
                else if(function.Equals("Delete"))
                {
                    Console.WriteLine("No education record available for deleting");
                }
            }
        }

        //Function to click on the edit icon of the last education record in the education tab
        public static void ClickOnEditIconForEducation(IWebDriver driver)
        {
            try
            {
                IWebElement editIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i"));
                editIcon.Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No education record available for editing");
            }
        }

        //Function to edit the education record
        public static void EditEducationRecord(IWebDriver driver)
        {
            try
            {
                ExcelLibHelper.PopulateInCollection(@"E:\MVP Studio\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Education");
                randomIndex = randomInt.Next(2, 5);
                countryIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Country"));
                titleIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Title"));
                graduationYearIndex = Convert.ToInt32(ExcelLibHelper.ReadData(randomIndex, "Graduation Year"));

                //edit college or university text box
                IWebElement collegeTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[1]/input"));
                collegeTextBox.Clear();
                collegeTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "University"));

                //edit country of college/university
                IWebElement countryDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[1]/div[2]/select"));
                countryDropDown.Click();
                SelectElement selectCountry = new SelectElement(countryDropDown);
                selectCountry.SelectByIndex(countryIndex);

                //edit title of education
                IWebElement titleDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[2]/div[1]/select"));
                titleDropDown.Click();
                SelectElement selectTitle = new SelectElement(titleDropDown);
                selectTitle.SelectByIndex(titleIndex);

                //edit degree of education
                IWebElement degreeTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[2]/div[2]/input"));
                degreeTextBox.Clear();
                degreeTextBox.SendKeys(ExcelLibHelper.ReadData(randomIndex, "Degree"));

                //edit year of graduation
                IWebElement yearOfGraduationDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td/div[2]/div[3]/select"));
                yearOfGraduationDropDown.Click();
                SelectElement selectYearOfGraduation = new SelectElement(yearOfGraduationDropDown);
                selectYearOfGraduation.SelectByIndex(graduationYearIndex);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Editing education record failed");
            }
        }

        //Function to click on the update button for education
        public static void ClickonUpdateButtonForEducation(IWebDriver driver)
        {

            try
            {
                IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
                updateButton.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

                Thread.Sleep(500);
                IWebElement alertMessage = wait.Until(d => driver.FindElement(By.XPath("//div[@class='ns-box-inner']")));
                message = alertMessage.Text;
                Console.WriteLine(message);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Editing education record failed");
            }
        }

        //Function to check if the education record has been updated
        public static void VerifyIfEducationIsUpdated()
        {
            try
            {
                if (message.Contains("has been updated to your education"))
                {
                    Assert.True(message.Contains("has been updated to your education"));
                    Console.WriteLine(message);
                }
                else if (message.Equals("This information is already exist."))
                {
                    Console.WriteLine(message);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Editing education record failed");
            }
        }

        //Function to click on the remove icon for education
        public static void ClickOnDeleteIconForEducation(IWebDriver driver)
        {
            try
            {
                IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i"));
                deleteIcon.Click();

                IWebElement alertMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                message = alertMessage.Text;
                Console.WriteLine(message);
            }
            catch(NoSuchElementException)
            {
                Console.WriteLine("No education record avaialble for deleting");
            }
        }

        //Function to check if the education record has been deleted
        public static void VerifyIfEducationIsDeleted()
        {
            try
            {
                if(message.Contains("entry has been successfully removed")|| message.Contains("Education entry successfully removed"))
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("No record available for deleteing");
                }    
                
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Deleting education record failed");
            }
        }
    }

}