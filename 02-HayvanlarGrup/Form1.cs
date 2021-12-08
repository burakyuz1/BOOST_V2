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

namespace _02_HayvanlarGrup
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server =.; database=AnkaraBoost5Db; uid= sa; pwd = 123");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            con.Open();
            InitializeComponent();
            dgvHayvanlar.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            HayvanlariListele();
            HayvanSayisiGetir();
        }

        private void HayvanlariListele()
        {
            cmd = new SqlCommand("SELECT * FROM Hayvanlar ORDER BY Id", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string cinsiyet = (dr["cinsiyet"].ToString() == "F") ? "Disi" : "Erkek";

                dgvHayvanlar.Rows.Add(dr["Id"], dr["Ad"], cinsiyet, dr["SahibiVarMi"], dr["DogumTarihi"], dr["Kutle"], dr["Tur"]);
            }
            dr.Close();
        }

        private void HayvanSayisiGetir()
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM Hayvanlar",con);
            int hayvanSayisi = (int)cmd.ExecuteScalar();
            grpHayvanlar.Text += hayvanSayisi.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string cinsiyet;
            if (rdoErkek.Checked)
                cinsiyet = "M";
            if(rdoDisi.Checked)
                cinsiyet = "F";
            if(rdoBelirsiz.Checked)
                cinsiyet = null;

            DateTime dogumTarihi = dtpDogumTarihi.Value;
            decimal kutle = nmuKutle.Value;

            bool sahibiVarMi = chbSahibiVarMi.Checked ? true : false;
          
            //cmd = new SqlCommand("INSERT INTO Hayvanlar ")





        }
    }
}
