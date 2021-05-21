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
            //test
        }

        [SetUp]
        public void Initialize()
        {
            //create reference as global variable
            
            Props.driver = new ChromeDriver();
            driver = Props.driver;
            //open browser
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html");
            Console.WriteLine("abri la url");
        }

        [Test]
        public void ExecuteTest()
        {
            //EnterText (element,value,type)
            SetMethods.EnterText("FirstName", "hiii","id");
            string firstName = GetMethods.GetText( "FirstName", "id");
            Console.WriteLine("escribi: " + firstName);

            // hay que pasarle la instancia del driver tmb

            SetMethods.SelectDropDown("TitleId", "2", "id");            
            Console.WriteLine("seleccione: " + GetMethods.GetText("TitleId", "id"));
                        
        }

        public void TestClick()
        {
            SetMethods.Click("Save", "name");

            SetMethods.Click("generate", "name");
            Console.WriteLine("clickie");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("cerre browser");
        }


        public void old()
        {
            //create reference as global variable
            IWebDriver driver = new ChromeDriver();

            //open browser
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html");
            Console.WriteLine("abri la url");

            //find element
            IWebElement element = driver.FindElement(By.Name("q"));

            //do the thing
            element.SendKeys("hello world");
            Console.WriteLine("hice el test");

            //stahp
            driver.Close();
            Console.WriteLine("cerre browser");
        }














    }
}
