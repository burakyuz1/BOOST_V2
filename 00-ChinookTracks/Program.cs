using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ChinookTracks
{
    class Program
    {
        static void Main(string[] args) //CONNECTED MIMARİ
        {
            SqlConnection con = new SqlConnection("server=. ; database = Chinook; uid = sa; pwd = 123");
            con.Open();

            SqlCommand cmd = new SqlCommand("select top 50 t.TrackId, t.Name, t.Composer, t.Milliseconds, g.Name as GenreName from track t join Genre g on t.GenreId = g.GenreId order by t.TrackId desc", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr["TrackId"]} {dr["Name"]} {dr["Composer"]} {dr["Milliseconds"]} {dr["GenreName"]}");
            }

            dr.Close();
            con.Close();
            Console.ReadKey();
        }
    }
}
