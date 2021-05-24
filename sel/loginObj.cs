using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageFactory = OpenQA.Selenium.Support.PageObjects.PageFactory;

namespace sel
{
    class loginObj
    {

        public loginObj()
        {
            PageFactory.InitElements(Props.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")] // identify element
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")] // identify element
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")] // identify element
        public IWebElement btnLogin { get; set; }


        public pom Login(string user, string pass)
        {
            //login
            txtUserName.EnterText(user);
            txtPassword.EnterText(pass);
            //click
            btnLogin.Clicks(); // toma unos segundos cargar nueva pagina

            
            return new pom(); //page obj model // will initialize and return page
        }
    }
}
