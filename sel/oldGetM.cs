using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace sel
{
    class oldGetM
    {
        static IWebDriver driver = Props.driver;
        //EnterText (element,value,type)

        public static string GetText(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        public static string GetSelectedText(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
