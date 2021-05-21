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
        public static void EnterText(string element, string value, string elementtype)
        {
            if (elementtype == "Id" || elementtype == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name" || elementtype == "name")
                driver.FindElement(By.Name(element));
        }

        public static void Click(string element, string elementtype)
        {
            if (elementtype == "Id" || elementtype == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name" || elementtype == "name")
                driver.FindElement(By.Name(element));
            if (elementtype == "Button" || elementtype == "button")
                driver.FindElement(By.CssSelector(element));
        }

        public static void SelectDropDown(string element, string value, string elementtype)
        {
            // SelectElement selElement = new SelectElement();
            if (elementtype == "Id" || elementtype == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByValue(value);
            if (elementtype == "Name" || elementtype == "name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByValue(value);
        }
    }
}
