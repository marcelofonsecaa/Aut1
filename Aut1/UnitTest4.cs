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

            action.Click(driver.FindElement(pagina.womenbtn)).Perform();
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(pagina.validarWomen));
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,1000);");
            action.Click(driver.FindElement(pagina.LogoPrincipal)).Perform();



        }

        [TestCleanup]
        public void finalizar()
        {
            driver.Quit();
            driver = null;
        }
    }
}

