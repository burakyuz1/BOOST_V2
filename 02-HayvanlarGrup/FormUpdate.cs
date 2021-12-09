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
    public partial class FormUpdate : Form
    {
        private readonly int id;
        private readonly SqlConnection _con;
        private SqlCommand cmd;
        //SqlConnection con = new SqlConnection("server =.; database=AnkaraBoost5Db; uid= sa; pwd = 123");
        public FormUpdate(int id, SqlConnection con)
        {
            InitializeComponent();
            this.id = id;
            _con = con;
            BilgileriGetir(id);
            //con.Open();
        }

        private void BilgileriGetir(int id)
        {
            cmd = new SqlCommand("SELECT  * FROM Hayvanlar WHERE Id = @p1", _con);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr.GetString(2);
                //if (dr.GetString(3) == null) rdoBelirsiz.Checked = true;
                if (dr[3] == DBNull.Value) rdoBelirsiz.Checked = true;
                else if (dr.GetString(3) == "F") rdoDisi.Checked = true;
                else if (dr.GetString(3) == "M") rdoErkek.Checked = true;
                dtpDogumTarihi.Value = dr.GetDateTime(7);
                txtTur.Text = dr.GetString(6);
                nmuKutle.Value = dr.GetDecimal(5);
                if (dr.GetBoolean(4)) chbSahibiVarMi.Checked = true;
                else chbSahibiVarMi.Checked = false;
            }
            dr.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string tur = txtTur.Text.Trim();
            if (ad == "" && tur == "")
            {
                MessageBox.Show("Gerekli alanları doldurun");
                return;
            }
            string cinsiyet = "";
            if (rdoErkek.Checked)
                cinsiyet = "M";
            if (rdoDisi.Checked)
                cinsiyet = "F";
            if (rdoBelirsiz.Checked)
                cinsiyet = null;
            DateTime dogumTarihi = dtpDogumTarihi.Value;
            decimal kutle = nmuKutle.Value;
            bool sahibiVarMi = chbSahibiVarMi.Checked ? true : false;

            cmd = new SqlCommand("UPDATE Hayvanlar SET Ad = @p1 , Cinsiyet = @p2 , SahibiVarMi = @p3 , Kutle = @p4, Tur = @p5 , DogumTarihi = @p6 where Id = @p7", _con);
            cmd.Parameters.AddWithValue("@p1", ad);
            cmd.Parameters.AddWithValue("@p2", cinsiyet);
            cmd.Parameters.AddWithValue("@p3", sahibiVarMi);
            cmd.Parameters.AddWithValue("@p4", kutle);
            cmd.Parameters.AddWithValue("@p5", tur);
            cmd.Parameters.AddWithValue("@p6", dogumTarihi);
            cmd.Parameters.AddWithValue("@p7", id);
            cmd.ExecuteNonQuery();


            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
