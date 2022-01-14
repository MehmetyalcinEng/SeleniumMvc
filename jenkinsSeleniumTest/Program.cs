using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace jenkinsSeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giris();


        }

        public static void Giris()
        {
            IWebDriver driver = new ChromeDriver();
            string link = "https://instagram.com";
            driver.Navigate().GoToUrl(link);
            Thread.Sleep(2000);
            IWebElement girisName = driver.FindElement(By.Name("username"));
            girisName.SendKeys("m.yalcin1906@gmail.com");
            Thread.Sleep(1000);
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("121212");
            Thread.Sleep(1000);
            IWebElement btnGirisYap = driver.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[3]"));
            btnGirisYap.Click();




        }



        public static void youtubeGiris()
        {

            IWebDriver driver = new ChromeDriver();
            string youtubeLink = "https://youtube.com";
            driver.Navigate().GoToUrl(youtubeLink);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.open()");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl("https://google.com.tr");

        }

    }
}
