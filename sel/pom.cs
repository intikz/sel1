using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageFactory = OpenQA.Selenium.Support.PageObjects.PageFactory;
//using FindsByAttribute = OpenQA.Selenium.Support.PageObjects.FindsByAttribute;
//using How = OpenQA.Selenium.Support.PageObjects.How;

namespace sel
{
    class pom
    {
        //EAPageObject
        //[FindsBy(How = How.Id, Using ="TitleId")] // identify element, How = how to find
        //public IWebElement TitleId { get; set; }

        public pom()
        {
            PageFactory.InitElements(Props.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")] // identify element
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")] // identify element
        public IWebElement txtName { get; set; }

        [FindsBy(How = How.Name, Using = "generate")] // identify element
        public IWebElement btnGen { get; set; }
        [FindsBy(How = How.Name, Using = "Save")] // identify element
        public IWebElement btnSave { get; set; }

        public void FillForm(string name)
        {
            //SetMethods.EnterText(txtName, name);  
            //SetMethods.Click(btnSave);
            
            txtName.EnterText(name);
            btnSave.Clicks();
            //txtName.SendKeys(name);
        }

    }
}
