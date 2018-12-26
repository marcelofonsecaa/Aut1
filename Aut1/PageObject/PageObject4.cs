using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aut1.PageObject
{
    class PageObject4
    {
        IWebDriver driver;
        public By womenbtn { get { return By.CssSelector("li:nth-child(1)"); } }
        public By validarWomen {  get {  return By.ClassName("content_scene_cat_bg"); } }
        public By LogoPrincipal {  get { return By.ClassName("logo img-responsive"); } }
    }
}
