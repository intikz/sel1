using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace sel
{

    class oldSetM
    {
        static IWebDriver driver = Props.driver;
        //enter text, click button, actions.

        //EnterText (element,value,type)
        //library methods should be static
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                driver.FindElement(By.Name(element));
        }

        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                driver.FindElement(By.Name(element)).Click();


        }

        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {
            // SelectElement selElement = new SelectElement();
            if (elementtype == PropertyType.Id)
                new SelectElement(driver.FindElement(By.Id(element))).SelectByValue(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(driver.FindElement(By.Name(element))).SelectByValue(value);
        }
    }
}
