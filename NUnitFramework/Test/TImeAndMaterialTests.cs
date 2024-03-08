using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Test
{
    [TestFixture]
    public class TImeAndMaterialTests : CommonDriver
    {
        [SetUp]
        public void SetUpTimeAndMaterial()
        {
           
            driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage();
            loginPage.LoginActions(driver, "hari", "123123");
            HomePage homePage = new HomePage();
            homePage.VerifyLoggedInUser(driver);
            homePage.NavigateToTMPage(driver);
        }
      
        [Test, Order(1), Description("This test create new Time/Material record with valid details")]
        public void TestCreateTimeAndMaterial() 
        {
            TimeAndMaterialPage timeAndMaterialPage = new TimeAndMaterialPage();
            timeAndMaterialPage.CreateTimeandMaterial(driver);
        }
        [Test, Order(2), Description("This test update new Time/Material record with valid data")]
        public void TestEditTimeAndMaterial()
        {
            
            TimeAndMaterialPage timeAndMaterialPage = new TimeAndMaterialPage();
            timeAndMaterialPage.editTimeAndMaterial(driver);
        }
        [Test, Order(3), Description("This test delete the last Time/Material record")]
        public void TestDeleteTimeAndMaterial()
        {
           
            TimeAndMaterialPage timeAndMaterialPage = new TimeAndMaterialPage();
            timeAndMaterialPage.deleteTimeAndMaterial(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
