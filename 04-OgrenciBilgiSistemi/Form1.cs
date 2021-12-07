using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=.; database = Boost11EkimDb; integrated security = true");
        public Form1()
        {
            con.Open();
            InitializeComponent();
            OgrencileriGetir();
        }

        private void OgrencileriGetir()
        {
            var cmd = new SqlCommand("SELECT * FROM Ogrenciler", con);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvOgrenciler.Rows.Add(dr[0], dr[1], dr[2]);
            }
            dr.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim() ;
            string soyad = txtSoyad.Text.Trim();

            var cmd = new SqlCommand("INSERT INTO Ogrenciler(Ad, Soyad) VALUES (@p1,@p2)",con);
            cmd.Parameters.AddWithValue("@p1", ad);
            cmd.Parameters.AddWithValue("@p2", soyad);
            cmd.ExecuteNonQuery();
            txtAd.Clear();
            txtSoyad.Clear();
            OgrencileriGetir();
        }
    }
}
