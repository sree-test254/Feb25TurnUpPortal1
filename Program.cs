using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Feb25TurnUpPortal1.Pages;

internal class Program
{
    private static void Main(string[] args)
    {
        // open web browser
        IWebDriver driver = new ChromeDriver();

        //Login Page object initialization and definition

        LoginPage loginPageObj = new LoginPage(); //class initialization
        loginPageObj.LoginActions(driver);

        //Homepage object initialization and definition

        Homepage homePageObj = new Homepage();
        homePageObj.NavigateToTMPage(driver);

        //Time and material initialization and definition

        TMpage tmPageObj = new TMpage();
        tmPageObj.CreateTimeRecord(driver);
        tmPageObj.EditTimeRecord(driver);
        tmPageObj.DeleteTimeRecord(driver);
         

        //check if user has login successfully


        /*IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("login successfully. Test passed");
        }
        else
        {
            Console.WriteLine(" login unsucessfull. Test Failed");
        }
        */
       




    }
}