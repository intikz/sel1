using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// no implrementado pq no tengo tabla
namespace tables
{
    public class Utilities
    {
        static List<TableDatacollection> _tableDatacollections = new List<TableDatacollection>();

        public static void ReadTable(IWebElement table)
        {
            //get all the columns from the table
            var columns = table.FindElements(By.TagName("th"));
            
            //get all rows
            var rows = table.FindElements(By.TagName("tr"));

            //creat row index
            int rowIndex = 0;

            foreach(var row in rows)
            {
                int colIndex = 0;
                var colDatax = row.FindElements(By.TagName("td")); //get data from row

                foreach(var colValue in colDatax)
                {
                    _tableDatacollections.Add(new TableDatacollection
                    {
                        RowNumber = rowIndex,
                        ColName= columns[colIndex].Text,
                        ColValue = colValue.Text
                    });
                    //move to next column

                    colIndex++;
                }
                rowIndex++;
            }
        }

        public static string ReadCell(string columnName, int rowNumber) // le paso location
        {
            //same as above so below.
            var data = (from e in _tableDatacollections
                        where e.ColName == columnName && e.RowNumber == rowNumber
                        select e.ColValue).SingleOrDefault();

            return data; //returns column value
        }
    }

    public class TableDatacollection
    {
        public int RowNumber { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
    }
}
