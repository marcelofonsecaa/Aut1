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
        public By futbtn { get { return By.Name("&lpos=sitenavdefault+sitenav_soccer"); } }
        public By palmeiras { get { return By.CssSelector("a.sprite-soccer-teams-25.sprite-25-team-2029"); } }
        public By corinthians { get { return By.CssSelector("a.sprite-soccer-teams-25.sprite-25-team-874"); } }
        public By spfc { get { return By.CssSelector("a.sprite-soccer-teams-25.sprite-25-team-2026"); } }
        public By santos { get { return By.CssSelector("a.sprite-soccer-teams-25.sprite-25-team-2674"); } }

    }
}
