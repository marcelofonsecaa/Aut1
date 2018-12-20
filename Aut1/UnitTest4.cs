using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Aut1
{
    [TestClass]
    public class UnitTest4
    {
        IWebDriver driver;
        PageObject.PageObject4 pagina;

        [TestInitialize]
        public void Iniciar()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/index.php";
        }

        [TestMethod]
        public void TestMethod4()
        {
            pagina = new PageObject.PageObject4();
            Actions action = new Actions(driver);
            //action.Click(driver.FindElement(pagina.signbtn)).Perform();
            //System.Threading.Thread.Sleep(2000);
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("window.scrollBy(0,200);");
            //action.Click(driver.FindElement(pagina.tboxemail)).Perform();
            //action.Click(driver.FindElement(pagina.tboxemail)).SendKeys("12345@hotmail.com").Perform();
            //pagina.tboxemail.Click();
            //pagina.tboxemail.SendKeys("12345@hotmail.com");
            action.Click(driver.FindElement(pagina.womenbtn)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.topbtn)).Perform();
            //pagina.topbtn.Click();
            System.Threading.Thread.Sleep(2000);







        }

    }
}
