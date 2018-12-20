using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Aut1
{
    [TestClass]
    public class UnitTest2
    {
        IWebDriver driver;
        PageObject.PageObject2 pagina;


        [TestInitialize]
        public void Iniciar()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.guru99.com/test/radio.html";
        }
        [TestMethod]
        public void TestMethod2()
        {
            pagina = new PageObject.PageObject2();
            Actions action = new Actions(driver);
            action.Click(driver.FindElement(pagina.radio1)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.radio2)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.radio3)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.check1)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.check2)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.check3)).Perform();
            System.Threading.Thread.Sleep(2000);
        }
        [TestCleanup]
        public void Finalizar()
        {
            driver.Quit();
            driver = null;
        }
    }
}
