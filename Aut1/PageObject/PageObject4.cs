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
        public By signbtn { get { return By.ClassName("header_user_info"); } }
        public By submitbtn { get { return By.Id("SubmitCreate"); } }
        //public By tboxemail { get { return By.Name("email_create"); } }
        public By womenbtn { get { return By.CssSelector("li:nth-child(1)"); } }
        public By topbtn { get { return By.XPath("(//a[@href='http://automationpractice.com/index.php?id_category=4&controller=category'])"); } }
        public By dressbtn {  get { return By.LinkText("http://automationpractice.com/index.php?id.category=8&controller=category"); } }
    }
}
