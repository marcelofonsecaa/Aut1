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
    class PageObject3
    {
        public By radioida { get { return By.Id("air-travel-choice-one"); } }
        public By radiovolta { get { return By.Id("air-travel-choice-two"); } }
        public By checkbox {  get { return By.Id("ember880"); } }
        //public IWebElement combobox1 = driver.FindElement(By.Id("ember913")); 
        public By combobox1 { get { return By.Id("ember913"); } }
        public By combobox2 { get { return By.Id("ember932"); } }
        public By textbox11 { get { return By.Id("ember-power-select-typeahead-input-ember807"); } }
        public By textbox12 { get { return By.Id("ember-power-select-typeahead-input-ember801"); } }
        public By textbox2  { get { return By.Id("ember-power-select-typeahead-input-ember846"); } }
        public By submitbtn {  get { return By.ClassName("button-primary-alt extend redo-search"); } }
        public By idabtn {  get { return By.ClassName("datepicker-input.product-form-input.ember-view"); } }
        public By voltabtn { get { return By.ClassName("datepicker-input.product-form-input pikaday-return-date.ember-view"); } }
        //public IWebElement dropDownListBox = driver.findElement(By.Id("ember1014"));
        public By dropDownListBox { get { return (By.Id("ember1014")); } }

    }
}
