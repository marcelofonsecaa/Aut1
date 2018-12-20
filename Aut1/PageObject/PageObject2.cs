using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aut1.PageObject
{
    class PageObject2
    {
        public By radio1 { get { return By.Id("vfb-7-1"); } }
        public By radio2 { get { return By.Id("vfb-7-2"); } }
        public By radio3 { get { return By.Id("vfb-7-3"); } }
        public By check1 { get { return By.Id("vfb-6-0"); } }
        public By check2 { get { return By.Id("vfb-6-1"); } }
        public By check3 { get { return By.Id("vfb-6-2"); } }

    }
}
