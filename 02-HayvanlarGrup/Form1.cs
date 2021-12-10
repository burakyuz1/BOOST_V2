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
            rdoBelirsiz.Checked = true;
            HayvanlariListele();
            HayvanSayisiGetir();
        }

        private void HayvanlariListele()
        {
            dgvHayvanlar.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM Hayvanlar", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string cinsiyet = (dr["cinsiyet"].ToString() == "F") ? "Disi" : "Erkek";
                if (dr["cinsiyet"].ToString() == "F")
                    cinsiyet = "Disi";
                else if (dr["cinsiyet"].ToString() == "M")
                    cinsiyet = "Erkek";
                else
                    cinsiyet = "Belirsiz";

                dgvHayvanlar.Rows.Add(dr["Id"], dr["Ad"], cinsiyet, dr["SahibiVarMi"], dr["DogumTarihi"], dr["Kutle"], dr["Tur"]);
            }
            dr.Close();
        }

        private void HayvanSayisiGetir()
        {
            cmd = new SqlCommand("SELECT COUNT(*) FROM Hayvanlar", con);
            int hayvanSayisi = (int)cmd.ExecuteScalar();
            grpHayvanlar.Text = "Hayvan Sayisi: " + hayvanSayisi.ToString();

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

            cmd = new SqlCommand("INSERT INTO Hayvanlar(Ad, Cinsiyet, SahibiVarMi, Kutle, Tur, DogumTarihi) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", con);
            cmd.Parameters.AddWithValue("@p1", ad);
            cmd.Parameters.AddWithValue("@p2", cinsiyet);
            cmd.Parameters.AddWithValue("@p3", sahibiVarMi);
            cmd.Parameters.AddWithValue("@p4", kutle);
            cmd.Parameters.AddWithValue("@p5", tur);
            cmd.Parameters.AddWithValue("@p6", dogumTarihi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Hayvan Eklendi.");
            HayvanlariListele();
            AlanlariSifirla();
            dgvHayvanlar.FirstDisplayedScrollingRowIndex = dgvHayvanlar.RowCount - 1;
            dgvHayvanlar.Rows[dgvHayvanlar.Rows.Count - 1].Selected = true;

        }

        private void AlanlariSifirla()
        {
            txtAd.Text = "";
            txtTur.Text = "";
            nmuKutle.Value = 1m;
            chbSahibiVarMi.Checked = false;
            dtpDogumTarihi.Value = DateTime.Now;
            rdoBelirsiz.Checked = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvHayvanlar.SelectedRows.Count > 0)
            {
                try
                {
                    var hayvanId = dgvHayvanlar.SelectedRows[0].Cells[0].Value;
                    cmd = new SqlCommand("DELETE FROM Hayvanlar WHERE Id = @p1", con);
                    cmd.Parameters.AddWithValue("@p1", hayvanId);
                    cmd.ExecuteNonQuery();
                    HayvanlariListele();
                    HayvanSayisiGetir();
                    MessageBox.Show("Hayvanı Sildiniz");
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir hata oluştu. Hayvan silinmedi.");
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int hayvanId = (int)dgvHayvanlar.SelectedRows[0].Cells[0].Value;
            FormUpdate fu = new FormUpdate(hayvanId, con);
            fu.ShowDialog();
            HayvanlariListele();
            dgvHayvanlar.FirstDisplayedScrollingRowIndex = hayvanId - 1;
            dgvHayvanlar.Rows[hayvanId - 1].Selected = true;
        }


        private void dgvHayvanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int hayvanId = (int)dgvHayvanlar.SelectedRows[0].Cells[0].Value;
            int yiyecekId = 0;
            cmd = new SqlCommand("Select top 1 YiyecekId from Hayvanlar WHERE Id = @p ", con);
            cmd.Parameters.AddWithValue("@p", hayvanId);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yiyecekId = (int)dr[0];
            }
            dr.Close();
            FormFavori ff = new FormFavori(yiyecekId, con);
            ff.ShowDialog();
        }
    }
}
