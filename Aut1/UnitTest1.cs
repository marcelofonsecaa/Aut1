using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Aut1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        PageObject.PageObject1 pagina;

        [TestInitialize]
        public void Iniciar()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://www.espn.com.br/";
        }

        [TestMethod]
        public void TestMethod1()
        {
            pagina = new PageObject.PageObject1();
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(pagina.futbtn)).Perform();
            System.Threading.Thread.Sleep(3000);
            action.MoveToElement(driver.FindElement(pagina.palmeiras)).Perform();
            System.Threading.Thread.Sleep(3000);
            action.Click(driver.FindElement(pagina.palmeiras)).Perform();
            //pagina.porcada.Click();
            System.Threading.Thread.Sleep(3000);
        }
        [TestCleanup]
        public void Finalizar()
        {
            driver.Quit();
            driver = null;
        }
    }
}
