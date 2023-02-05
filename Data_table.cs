using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    public class Data_table
    {
        public  void insertdata()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("IsLike");

            table.Rows.Add("1","9","5","Excellent","true");
            table.Rows.Add("2", "6", "4", "Excellent", "true");
            table.Rows.Add("3", "2", "3", "Excellent", "true");
            table.Rows.Add("4", "7", "3", "Excellent", "false");
            table.Rows.Add("5", "6", "5", "Excellent", "true");
            table.Rows.Add("6", "3", "1", "Excellent", "false");
            table.Rows.Add("7", "8", "1", "Excellent", "false");
            table.Rows.Add("8", "9", "4", "Excellent", "true");
            table.Rows.Add("9", "9", "5", "Excellent", "false");
            table.Rows.Add("10", "5", "5", "Excellent", "true");
            table.Rows.Add("11", "4", "1", "Excellent", "false");
            table.Rows.Add("12", "9", "2", "Excellent", "true");
            table.Rows.Add("13", "4", "2", "Excellent", "false");
            table.Rows.Add("14", "4", "1", "Excellent", "true");
            table.Rows.Add("15", "8", "5", "Excellent", "true");
            table.Rows.Add("16", "7", "4", "Excellent", "false");
            table.Rows.Add("17", "1", "4", "Excellent", "true");
            table.Rows.Add("18", "1", "3", "Excellent", "true");
            table.Rows.Add("19", "6", "5", "Excellent", "false");
            table.Rows.Add("20", "8", "3", "Excellent", "true");
            table.Rows.Add("21", "2", "4", "Excellent", "true");
            table.Rows.Add("22", "3", "2", "Excellent", "false");
            table.Rows.Add("23", "3", "1", "Excellent", "false");
            table.Rows.Add("24", "7", "1", "Excellent", "false");
            table.Rows.Add("25", "7", "4", "Excellent", "true");

            Data_table D = new Data_table();
            // D.DisplayProducts(table);
            D.Display_IsLike_True(table);
        }

        public void DisplayProducts(DataTable dt)
        {
            var prodName = from products in dt.AsEnumerable()
                           select products.Field<String>("ProductID");
            foreach (var prd in prodName)
            {
                Console.WriteLine(prd);
            }
        }

        public void Display_IsLike_True(DataTable dt)
        {
            var prodName = from products in dt.AsEnumerable() where products.Field<String>("IsLike") == "true"
                           select products.Field<String>("ProductID");
            foreach (var prd in prodName)
            {
                Console.WriteLine(prd);
            }
        }
    }
}
