using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace sel
{
    
    class SetMethods
    {
        static IWebDriver driver = Props.driver;
        //enter text, click button, actions.

        //EnterText (element,value,type)
        //library methods should be static
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void Click(IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
