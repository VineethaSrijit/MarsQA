using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class HomePage
    {
        //Click on the Profile tab in the home page
        public static void GoToProfilePage(IWebDriver driver)
        {
            IWebElement profilePage = driver.FindElement(By.XPath("//a[normalize-space()='Profile']"));
            profilePage.Click();
        }

                
    }
}
