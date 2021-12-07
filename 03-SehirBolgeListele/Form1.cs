using _03_SehirBolgeListele.Classes;
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

namespace _03_SehirBolgeListele
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server = . ; database = Boost11EkimDb ; trusted_connection = true");
        public Form1()
        {
            con.Open();
            InitializeComponent();
            BolgeleriGetir();
        }

        private void BolgeleriGetir()
        {
            var cmd = new SqlCommand("Select Id, BolgeAd FROM Bolgeler", con);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
                cmbBolgeler.Items.Add(new Bolge() { Id = (int)dr[0], BolgeAd = (string)dr[1] });
            dr.Close();
        }

        private void cmbBolgeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBolgeler.SelectedIndex == -1)
            {
                lstSehirler.Items.Clear();
                return;
            }

            Bolge bolge = (Bolge)cmbBolgeler.SelectedItem;
            SehirleriGetir(bolge.Id);

        }

        private void SehirleriGetir(int id)
        {
            lstSehirler.Items.Clear();
            var cmd = new SqlCommand("SELECT * FROM Sehirler WHERE BolgeId = @p",con);
            cmd.Parameters.AddWithValue("@p", id);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lstSehirler.Items.Add(new Sehir()
                {
                    Id = (int)dr["Id"],
                    BolgeId = (int)dr["BolgeId"],
                    Nufus = (int)dr["Nufus"],
                    SehirAd = (string)dr["SehirAd"]

                });
            }
            dr.Close();

        }
    }
}
