using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb25TurnUpPortal1.Utilities;
using OpenQA.Selenium;

namespace Feb25TurnUpPortal1.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            // luanch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //identify username textbox and enter valid username
            IWebElement userNameTextbox = driver.FindElement(By.Id("UserName"));
            userNameTextbox.SendKeys("hari");

            Wait.WaittobeVisible(driver, "Id", "Password", 10);
            //identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify login button and click on it
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbutton.Click();
            Thread.Sleep(2000);
        }

    }
}
