using NUnit.Framework;
using OpenQA.Selenium;
using TestProjectExamplePage.Page;
using TestProjectExamplePage.WebDriver;

namespace TestProjectExamplePage
{
    public class Tests
    {
        public class TestClass
        {
            private LoginPage _loginPage;
            private HomePage _homePage;

            [SetUp]

            public void BeforeScenario()
            {
                WebDrivers.Initialize();
                _loginPage = new LoginPage();
                _homePage = new HomePage();

            }

            [TearDown]
            public void AfterScenario()
            {
                WebDrivers.CleanUp();
            }

          

            [Test]

            public void TC01_FillInAllData()
            {

                Login("Jovana", "12345");

                _homePage.Country.SendKeys("Serbia");
                _homePage.Address.SendKeys("Masarikova");
                _homePage.Email.SendKeys("testdomaci.com");
                _homePage.Phone.SendKeys("12345678");
                _homePage.Save.Click();
                _homePage.LogoutButton.Click();


            }

            public void Login(string name, string pass)
            {
                _loginPage.LoginUser(name, pass);
            }

        }
    }
}