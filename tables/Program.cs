//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{// no implrementado pq no tengo tabla html
    class Program : Base
    {       

        static void Main(string[] args)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("file:///C:/Users/Inti%20AcostayLara/Source/Repos/sel1/Data.xlsx");

            TablePage page = new TablePage();

            //Read table            
            Utilities.ReadTable(page.table);

            //Get cell value from table
            Console.WriteLine(Utilities.ReadCell("UserName", 4)); // {1}

            Console.Read();

        }
    }
}
