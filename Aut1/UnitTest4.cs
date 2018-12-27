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


            // Definindo o tempo do TimeSpan
            TimeSpan time = new TimeSpan(00, 00, 05);

            // Instanciando a classe WebDriverWait
            WebDriverWait wait = new WebDriverWait(driver, time);

            // Instanciando a classe Actions para interagir com os elementos da tela
            Actions action = new Actions(driver);

            // Instanciando a PageObject referente ao teste
            pagina = new PageObject.PageObject4();

            action.Click(driver.FindElement(pagina.womenBtn)).Perform();
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(pagina.validarWomen));

            // Estanciando classe IJavaScriptExecutor para usar scroll up e scroll down na pagina
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,1000);");
            System.Threading.Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,-1000);");

            wait.Until(ExpectedConditions.ElementExists(pagina.textBox1));

            driver.FindElement(pagina.textBox1).SendKeys("dresses");
            driver.FindElement(pagina.textBox1).Submit();
            System.Threading.Thread.Sleep(1000);

            var selectTest = new SelectElement(driver.FindElement(pagina.comboSortBy));
            selectTest.SelectByText("Price: Lowest first");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(pagina.listItens).Click();
            driver.FindElement(pagina.gridItens).Click();
            js.ExecuteScript("window.scrollBy(0,1500);");
            driver.FindElement(pagina.caixaVestido).Click();


            action.Click(driver.FindElement(pagina.maisBtn)).Perform();

            //driver.FindElement(pagina.caixona2).Click();
            //driver.FindElement(pagina.caixona2.FindElement(pagina.maisBtn)).Click();
            //driver.FindElement(pagina.maisBtn).Click();

            var selectSize = new SelectElement(driver.FindElement(pagina.sizeCbox));
            selectTest.SelectByText("L");
            System.Threading.Thread.Sleep(1000);






        }

        [TestCleanup]
        public void finalizar()
        {
            driver.Quit();
            driver = null;
        }
    }
}

