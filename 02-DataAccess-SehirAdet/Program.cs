using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccess_SehirAdet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var con = new SqlConnection("server=.; database = Boost11EkimDb; trusted_connection = true;");
            con.Open();
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Sehirler", con);
            int adet = (int)cmd.ExecuteScalar();
            Console.WriteLine($"Türkiye'de {adet} adet şehir var.");
            con.Close();

            Console.ReadKey();
        }
    }
}
