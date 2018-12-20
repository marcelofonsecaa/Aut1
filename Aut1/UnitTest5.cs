using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Aut1
{
    [TestClass]
    public class UnitTest5
    {
        IWebDriver driver;
        PageObject.PageObject5 pagina;

        [TestInitialize]
        public void Iniciar()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.newtours.demoaut.com/mercurywelcome.php";
        }
        
        [TestMethod]
        public void TestMethod5()
        {
            pagina = new PageObject.PageObject5();
            Actions action = new Actions(driver);
            action.Click(driver.FindElement(pagina.signbtn)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.registerbtn)).Perform();

            //action.Click(driver.FindElement(pagina.signbtn)).Perform();
            //action.Click(driver.FindElement(pagina.flybtn)).Perform();
            //System.Threading.Thread.Sleep(2000);

        }
        [TestCleanup]
        public void Finalizar()
        {
            driver.Quit();
            driver = null;
        }
    }
}
