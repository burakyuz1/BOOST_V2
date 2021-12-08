using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADONET CONNECTED MIMARI ILE NOTHWIND DATABASE'INDEKI
            //PRODUCT TABLOSUNU ÇEK (ADIM1)
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            //Product tablosunu cat. ile getiriniz(ADIM2)

            SqlConnection con = new SqlConnection("server=. ; database = Northwind; uid = sa; pwd = 123");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT ProductId, ProductName, UnitPrice FROM Products", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr["ProductId"]} -- {dr["ProductName"]} -- { dr["UnitPrice"]:C1}");
            }

            dr.Close();

            cmd = new SqlCommand("select c.CategoryName, p.ProductName from Products p JOIN Categories c ON c.CategoryId = p.CategoryID ", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr["CategoryName"]} -- {dr["ProductName"]}");
            };

            dr.Close();
            con.Close();
            Console.ReadLine();
        }
    }
}
