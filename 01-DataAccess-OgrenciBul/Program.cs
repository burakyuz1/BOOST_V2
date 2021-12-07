using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccess_OgrenciBul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aranacak Metin:");
            string metin = Console.ReadLine();
            // 1. Veri tabanına baglanti saglanır.
            SqlConnection con = new SqlConnection("server=.; database = Boost11EkimDb; trusted_connection = true;");
            con.Open();

            // 2. SQL Komutu oluşturulur.
            //SqlCommand cmd = new SqlCommand($"SELECT Ad, Soyad FROM Ogrenciler WHERE Ad LIKE '%{@metin}%' ", con); SAKINCALI YÖNTEM
            SqlCommand cmd = new SqlCommand("SELECT Ad, Soyad FROM Ogrenciler WHERE Ad LIKE @p OR Soyad LIKE @p");
            cmd.Parameters.AddWithValue("@p", "%" + metin + "%");

            // 3. Komut çalıştırılır ve veri okuyucu elde edilir.
            SqlDataReader dr = cmd.ExecuteReader();

            // 4. Sonuc kumesi satır satır okunur
            while (dr.Read())
                Console.WriteLine(dr[0] + " " + dr[1]);

            //5. işi biten nesneleri çöpe at.
            con.Close();

            Console.ReadKey();
        }
    }
}
