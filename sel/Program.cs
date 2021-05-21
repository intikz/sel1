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
        //create reference as global variable
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            //open browser
            driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine("abri la url");
        }

        [Test]
        public void ExecuteTest()
        {
            //find element
            IWebElement element = driver.FindElement(By.Name("q"));

            //do the thing
            element.SendKeys("hello world");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("cerre browser");
        }















    }
}
