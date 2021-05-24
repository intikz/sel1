using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageFactory = OpenQA.Selenium.Support.PageObjects.PageFactory;

namespace tables
{
    class TablePage :Base
    {
        public TablePage() //pom
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using ="//table")]


        public IWebElement table { get; set; }

    }
}
