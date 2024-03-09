using NUnit.Framework;
using NUnitFramework.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace NUnitFramework.Test
{
    [TestFixture]
    class CustomerTests : CommonDriver
    {
        
        [SetUp]
        public void SetUpCustomer()
        {

            driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage();
            loginPage.LoginActions(driver, "hari", "123123");
            HomePage homePage = new HomePage();
            homePage.VerifyLoggedInUser(driver);
            homePage.NavigateToCustomerPage(driver);
        }

        [Test]

        public void CreateCustomer()
        {
            CustomerPage customerPageObj = new CustomerPage();
            customerPageObj.CreateNewCustomer(driver);

        }

        [TearDown]
        public void TearDownCustomer()
        {
            driver.Quit();
        }
    }
}
