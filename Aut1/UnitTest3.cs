using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Aut1
{
    [TestClass]
    public class UnitTest3
    {
        IWebDriver driver;
        PageObject.PageObject3 pagina;

        [TestInitialize]
        public void Iniciar()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.cvc.com.br/";
        }
        [TestMethod]
        public void TestMethod3()
        {
            pagina = new PageObject.PageObject3();
            Actions action = new Actions(driver);


            action.Click(driver.FindElement(pagina.radioida)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.radiovolta)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.checkbox)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.MoveToElement(driver.FindElement(pagina.combobox1)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.textbox11)).SendKeys("Marilia").Perform();
            System.Threading.Thread.Sleep(2000);
            //action.Click(driver.FindElement(pagina.textbox12)).SendKeys("Marilia").Perform();
            //System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.textbox2)).SendKeys("Barueri").Perform();
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
