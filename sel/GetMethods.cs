using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace sel
{
    class GetMethods
    {
       static IWebDriver driver = Props.driver;
        //EnterText (element,value,type)

        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetSelectedText(IWebElement element)
        {
            
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            
        }
    }
}
