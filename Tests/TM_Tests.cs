using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feb25TurnUpPortal1.Pages;
using Feb25TurnUpPortal1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Feb25TurnUpPortal1.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver

    {
     
        [SetUp]
        public void SetUpSteps()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage(); //class initialization
            loginPageObj.LoginActions(driver);

            Homepage homePageObj = new Homepage();
            homePageObj.NavigateToTMPage(driver);

        }

        [Test]
        public void CreateTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.CreateTimeRecord(driver);
        }
        [Test]
        public void EditTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTimeRecord(driver);
        }
        [Test]
        public void DeleteTime_Test()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.DeleteTimeRecord(driver);
        }

        [TearDown]
        public void CloseRunTest()
        {
            driver.Quit();
        }
    }
}
