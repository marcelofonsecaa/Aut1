using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aut1.PageObject
{
    class PageObject1

    {
        //IWebElement pagina;
        public By futbtn { get { return By.Name("&lpos=sitenavdefault+sitenav_soccer"); } }
        //public IWebElement caixao { get { return pagina.FindElement(By.ClassName("dropdown-group")); } }
        public By palmeiras { get { return By.CssSelector("a.sprite-soccer-teams-25.sprite-25-team-2029"); } }
        //public IWebElement porcada {  get { return pagina.FindElement(By.CssSelector("a.sprite-soccer-teams-25.sprite-25-team-2029")); } }

            }
}
