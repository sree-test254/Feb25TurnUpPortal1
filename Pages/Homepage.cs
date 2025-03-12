using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb25TurnUpPortal1.Utilities;
using OpenQA.Selenium;

namespace Feb25TurnUpPortal1.Pages
{
    public class Homepage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationTab.Click();
            // Thread.Sleep(2000);
           
            Wait.Waittobeclickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);

            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();
            //Thread.Sleep(2000);

        }
    }
}
