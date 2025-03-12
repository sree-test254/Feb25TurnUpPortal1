using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Feb25TurnUpPortal1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Feb25TurnUpPortal1.Pages
{
    public class TMpage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            try
            {
                IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createNewButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Create new button hasnot been found");
            }
            // Click on Create new button
            
            //Thread.Sleep(2000);


            //select time from dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(2000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //Type code into code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Feb25TurnUpPortal");


            //type Description into Description textbox
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("This is description");

            //type price into price textbox

            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));

            priceTextBox.SendKeys("12");


            // click on save button
            Wait.Waittobeclickable(driver, "Id", "SaveButton", 5);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //check if the record is created sucessfully

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            goToLastPageButton.Click();


            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "Feb25TurnUpPortal" , "Record has not been created");

            //if (newCode.Text == "Feb25TurnUpPortal")
            //{
            //    Assert.Pass("Records created successfully");

            //}
            //else
            //{
            //    Assert.Fail("New records not to be created");
            //}

        }
            //edit time record
            public void EditTimeRecord(IWebDriver driver)
        {

        }

        //delete time record
        public void DeleteTimeRecord(IWebDriver driver)


        {

        }

    }
}

