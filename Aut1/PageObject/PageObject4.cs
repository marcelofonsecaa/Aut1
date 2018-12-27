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

        public By womenBtn { get { return By.CssSelector("li:nth-child(1)"); } }
        public By validarWomen {  get {  return By.ClassName("content_scene_cat_bg"); } }
        public By textBox1 { get { return By.Id("search_query_top"); } }
        public By submitBtn { get { return By.ClassName("btn.btn-default.button-search"); } }
        public By caixaGrandona {  get { return By.ClassName("header-container"); } }
        public By comboSortBy { get { return By.Id("selectProductSort"); } }
        public By listItens { get { return By.Id("list"); } }
        public By gridItens { get { return By.Id("grid"); } }
        public By caixaVestido { get { return By.XPath("//*[@id='center_column']/ul/li[7]/div/div[1]/div/a[1]/img"); } }
        public By maisBtn { get { return By.ClassName("icon-plus"); } }
        public By sizeCbox { get { return By.Id("uniform-group_1"); } }
        public By caixona2 { get { return By.ClassName("product.product-4.product-printed-dress.category-10.category-evening-dresses.hide-left-column.hide-right-column.content_only.lang_en"); } }
    }
}
