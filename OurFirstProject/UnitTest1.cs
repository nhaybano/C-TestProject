using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace OurFirstProject
{
    public class Tests
    {
        private IWebDriver drivel;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            drivel = new ChromeDriver();
            drivel.Manage().Window.Maximize();
           
        }
        [TearDown]
        public void TearDown()
        {

        }
        
        [Test]
        public void Test1()
        {
            drivel.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var signin = drivel.FindElements(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).SingleOrDefault();
            signin.Click();

            var a = drivel.FindElements(By.XPath("//*[@id='center_column']/h1")).SingleOrDefault();
            var b = a.Text;

            Assert.That(b, Is.EqualTo("AUTHENTICATION"));

        }
        [Test]
        public void Test2()
        {
            drivel.Navigate().GoToUrl("https://demoblaze.com/");
            var signup = drivel.FindElements(By.XPath("//*[@id='signin2']")).SingleOrDefault();
            signup.Click();
            Thread.Sleep(2000);
            //*[@id="sign-username"]
            //*[@id="sign-password"]
            //*[@id="signInModal"]/div/div/div[3]/button[2]

            var username= drivel.FindElements(By.XPath("//*[@id='sign-username']")).SingleOrDefault();
            var password = drivel.FindElements(By.XPath("//*[@id='sign-password']")).SingleOrDefault();
            var signupbutton = drivel.FindElements(By.XPath("//*[@id='signInModal']/div/div/div[3]/button[2]")).SingleOrDefault();
            username.SendKeys("ourusername");
            password.SendKeys("12345678");
            Thread.Sleep(1000);
            signupbutton.Click();
                














        }
    }
}