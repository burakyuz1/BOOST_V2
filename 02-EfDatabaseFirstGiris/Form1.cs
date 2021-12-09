using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_EfDatabaseFirstGiris
{
    public partial class Form1 : Form
    {
        Boost11EkimDbEntities db = new Boost11EkimDbEntities();
        public Form1()
        {
            InitializeComponent();
            OgrencileriGetir();
        }

        private void OgrencileriGetir()
        {
            dgvOgrenciler.DataSource = db.Ogrenciler.ToList();
    
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void dgvOgrenciler_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvOgrenciler.SelectedRows.Count != 1)
            {
                dgvHobiler.DataSource = null;
                return;
            }
            Ogrenci ogr = (Ogrenci)dgvOgrenciler.SelectedRows[0].DataBoundItem;
            dgvHobiler.DataSource = ogr.Hobiler.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(dgvOgrenciler.SelectedRows.Count !=1 )
            {
                dgvHobiler.DataSource = null;
                return;
            }
            Ogrenci ogr = (Ogrenci)dgvOgrenciler.SelectedRows[0].DataBoundItem;
            db.Ogrenciler.Remove(ogr);
            db.SaveChanges();
            OgrencileriGetir();
        }
    }
}
