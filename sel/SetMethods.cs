using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace sel
{
    
    static class SetMethods //add static because extends
    {
        static IWebDriver driver = Props.driver;
        //enter text, click button, actions.

        //EnterText (element,value,type)
        //library methods should be static

        //this, makes EnterText an extended method, linq
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
