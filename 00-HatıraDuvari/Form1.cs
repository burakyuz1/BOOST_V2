using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_HatıraDuvari
{
    public partial class Form1 : Form
    {
        int y = 13;
        HatiraDbContext db = new HatiraDbContext();
        public Form1()
        {
            InitializeComponent();
            HatiralariGetir();
        }

        private void HatiralariGetir()
        {

            foreach (var item in db.Hatiralar)
            {
                TextBox txt = new TextBox();
                txt.Text = item.Icerik + " ---- " + item.OlusturulmaZamani.ToString();
                txt.Size = new Size(432, 29);
                txt.Location = new Point(31, y);
                txt.ReadOnly = true;
                txt.BorderStyle = BorderStyle.None;
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
                HatiraEkle(txt);
                y += 45;
            }

        }

        private void btnHatiraEkle_Click(object sender, EventArgs e)
        {
            string icerik = txtHatıraIcerik.Text.Trim().ToUpper();
            if (icerik == "") return;
            y += 45;
            Hatira hatira = new Hatira()
            {
                Icerik = icerik
            };
            TextBox txt = new TextBox();
            txt.Text = hatira.Icerik + " --- " + hatira.OlusturulmaZamani.ToString();
            txt.Size = new Size(432, 29);
            txt.Location = new Point(13, y);
            txt.ReadOnly = true;
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.Red;
            txt.ForeColor = Color.White;
            db.Hatiralar.Add(hatira);
            db.SaveChanges();
            HatiralariGetir();
            HatiraEkle(txt);
            txtHatıraIcerik.Text = "";

        }
        private void HatiraEkle(TextBox txt)
        {
            pnlHatiralar.Controls.Add(txt);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //cRaZyBoY06
            List<Hatira> hatiras = db.Hatiralar.ToList();
            foreach (var item in hatiras)
            {
                string crazy = "cRaZyBoY06";
                if (item.Icerik == crazy)
                {
                    hatiras.Remove(item);
                }
            }

            
            
           

        }
    }
}
