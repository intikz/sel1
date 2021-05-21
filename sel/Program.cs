using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sel
{
    class Program
    {

        IWebDriver driver;
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            //create reference as global variable

            Props.driver = new ChromeDriver();
            driver = Props.driver;
            //open browser
            //driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html");
            Console.WriteLine("abri la url");
        }

        [Test]

        public void login()
        {
            loginObj pageLogin = new loginObj(); //initialize page and all its objects
            pom pageGeneral = pageLogin.Login("ini", "ini");
            pageGeneral.FillForm("ruby"); 
        }

        [Test]
        public void escribir()
        {
            pom page = new pom(); //initialize page and all its objects

            page.txtName.SendKeys("hello worlds");
        }

        [Test]
        public void TestClick() //este falla bien porque toca el boton que tira alert
        {
            pom page = new pom();
            page.btnGen.Click();
            Console.WriteLine("clickie");
        }

        //[Test]
        //public void oldTestClick()
        //{
        //    SetMethods.Click("Save", PropertyType.Name);

        //    SetMethods.Click("generate", PropertyType.Name);
        //    Console.WriteLine("clickie");
        //}

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("cerre browser");
        }

        //public void primitivo()
        //{
        ////EnterText (element,value,type)
        //SetMethods.EnterText("FirstName", "hiii", PropertyType.Id);
        //string firstName = GetMethods.GetText( "FirstName", PropertyType.Id);
        //Console.WriteLine("escribi: " + firstName);

        //// hay que pasarle la instancia del driver tmb

        //SetMethods.SelectDropDown("TitleId", "2", PropertyType.Id);            
        //Console.WriteLine("seleccione: " + GetMethods.GetText("TitleId", PropertyType.Id));
        //}

        //public void old()
        //{
        //    //create reference as global variable
        //    IWebDriver driver = new ChromeDriver();

        //    //open browser
        //    driver.Navigate().GoToUrl("http:/www.google.com");
        //    Console.WriteLine("abri la url");

        //    //find element
        //    IWebElement element = driver.FindElement(By.Name("q"));

        //    //do the thing
        //    element.SendKeys("hello world");
        //    Console.WriteLine("hice el test");

        //    //stahp
        //    driver.Close();
        //    Console.WriteLine("cerre browser");
        //}














    }
}
