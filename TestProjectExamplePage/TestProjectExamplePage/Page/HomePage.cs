﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectExamplePage.WebDriver;
using WebDriver = TestProjectExamplePage.WebDriver;

namespace TestProjectExamplePage.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Country => driver.FindElement(By.Id("country"));
        public IWebElement Address => driver.FindElement(By.Id("address"));
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement Phone => driver.FindElement(By.Id("phone"));
        public IWebElement Save => driver.FindElement(By.Id("save"));
        public IWebElement LogoutButton => driver.FindElement(By.Id("logout"));
        public IWebElement SaveText => driver.FindElement(By.ClassName("tp-saved"));

        public void SelectCountry(string country)
        {
            SelectElement element = new SelectElement(driver.FindElement(By.Id("country")));
            element.SelectByText(country);  
        }

    }

  
}
