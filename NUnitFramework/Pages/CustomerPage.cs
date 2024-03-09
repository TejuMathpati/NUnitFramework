using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace NUnitFramework.Pages
{
    public class CustomerPage : HomePage
    {
        public void CreateNewCustomer(IWebDriver driver)
        {
            //create new customer record
            IWebElement creatNewCutomerButton = driver.FindElement(By.XPath("//a[contains(text(),'Create New')]"));
            creatNewCutomerButton.Click();

            
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Sophie");

            //Edit Contact 
            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
           editContactButton.Click();

            driver.SwitchTo().Frame(0);
            

            IWebElement editFirstNameTextbox = driver.FindElement(By.Id("FirstName"));
            editFirstNameTextbox.SendKeys("Sophie");
            IWebElement editLastNameTextbox = driver.FindElement(By.Id("LastName"));
            editLastNameTextbox.SendKeys("Turner");
            IWebElement editPreferedNameTextbox = driver.FindElement(By.Id("PreferedName"));
            editPreferedNameTextbox.SendKeys("Sophie");
            IWebElement editPhoneTextbox = driver.FindElement(By.Id("Phone"));
            editPhoneTextbox.SendKeys("045000000");
            IWebElement editMobileTextbox = driver.FindElement(By.Id("Mobile"));
            editMobileTextbox.SendKeys("05676788");

            IWebElement editEmailTextbox = driver.FindElement(By.Id("email"));
            editEmailTextbox.SendKeys("sophie@gmail.com");

            IWebElement editFaxTextbox = driver.FindElement(By.Id("Fax"));
            editFaxTextbox.SendKeys("1234567");

            /*IWebElement editAddressTextbox = driver.FindElement(By.XPath("//input[@placeholder='Enter your address']"));
            editAddressTextbox.SendKeys("M");
            driver.SwitchTo().Frame(1);
            driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();
            //IAlert simpleAlert = driver.SwitchTo().Alert();
             editAddressTextbox.SendKeys("Melbourne");*/



            IWebElement editStreetTextbox = driver.FindElement(By.Id("Street"));
            editStreetTextbox.SendKeys("Station street");

            IWebElement editCityTextbox = driver.FindElement(By.Id("City"));
            editCityTextbox.SendKeys("Melbourne");

            IWebElement editPostCodeTextbox = driver.FindElement(By.Id("Postcode"));
            editPostCodeTextbox.SendKeys("3130");

            IWebElement editCountryTextbox = driver.FindElement(By.Id("Country"));
            editCountryTextbox.SendKeys("Austarlia");

            IWebElement saveContactButton = driver.FindElement(By.XPath("//input[@value='Save Contact']"));
            saveContactButton.Click();

            // Edit billing contact
            //WaitUtils.WaitToBeVisible(driver, "XPath", "//input[@type='checkbox']", 2);
            driver.SwitchTo().DefaultContent();
            IWebElement sameAsAboveCheckbox = driver.FindElement(By.Id("IsSameContact"));
            
            sameAsAboveCheckbox.Click();

            // Add GST record

            IWebElement gstTextbox = driver.FindElement(By.Id("GST"));
            gstTextbox.SendKeys("12");

            //save customer record

            IWebElement saveButton = driver.FindElement(By.XPath("//input[@value='Save']"));
            saveButton.Click();

            // Checking Customer Record is saved or not
            NavigateToCustomerPage(driver);
            Thread.Sleep(3000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

           
            IWebElement findLastRecord = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[2]"));
            
            Assert.That((findLastRecord.Text == "Sophie"), "The Customer record is not been created.");
               
           
        }
    }
}
