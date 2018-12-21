using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Aut1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        PageObject.PageObject1 pagina;
        PageObject.PageObject01 pagina1;

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
            pagina1 = new PageObject.PageObject01();
            Actions action = new Actions(driver);
            TimeSpan time = new TimeSpan(00, 00, 05);
            WebDriverWait wait = new WebDriverWait(driver, time);
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();

            // Noticias do Palmeiras
            action.MoveToElement(driver.FindElement(pagina.futbtn)).Perform();
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(pagina.palmeiras));
            action.MoveToElement(driver.FindElement(pagina.palmeiras)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.palmeiras)).Perform();

            wait.Until(ExpectedConditions.ElementIsVisible(pagina1.validar));

            String fp = "C://Users//ma20044294//Downloads//SS//" + "_" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".jpeg";
            screenshot.SaveAsFile(fp, OpenQA.Selenium.ScreenshotImageFormat.Png);
            System.Threading.Thread.Sleep(2000);


            // Noticias da gambazada
            action.MoveToElement(driver.FindElement(pagina.futbtn)).Perform();
            wait.Until(ExpectedConditions.ElementToBeClickable(pagina.corinthians));
            action.MoveToElement(driver.FindElement(pagina.corinthians)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.corinthians)).Perform();

            wait.Until(ExpectedConditions.ElementIsVisible(pagina1.validar));

            screenshot.SaveAsFile(fp, OpenQA.Selenium.ScreenshotImageFormat.Png);
            System.Threading.Thread.Sleep(2000);



            // Noticias da bixarada
            action.MoveToElement(driver.FindElement(pagina.futbtn)).Perform();
            wait.Until(ExpectedConditions.ElementToBeClickable(pagina.spfc));
            action.MoveToElement(driver.FindElement(pagina.spfc)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.spfc)).Perform();

            wait.Until(ExpectedConditions.ElementIsVisible(pagina1.validar));


            screenshot.SaveAsFile(fp, OpenQA.Selenium.ScreenshotImageFormat.Png);
            System.Threading.Thread.Sleep(2000);


            // Noticias das sardinhas
            action.MoveToElement(driver.FindElement(pagina.futbtn)).Perform();
            wait.Until(ExpectedConditions.ElementToBeClickable(pagina.santos));
            action.MoveToElement(driver.FindElement(pagina.santos)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.santos)).Perform();

            wait.Until(ExpectedConditions.ElementIsVisible(pagina1.validar));


            screenshot.SaveAsFile(fp, OpenQA.Selenium.ScreenshotImageFormat.Png);
            System.Threading.Thread.Sleep(2000);

        }
        [TestCleanup]
        public void finalizar()
        {
            driver.Quit();
            driver = null;
        }
    }
}


