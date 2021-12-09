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

namespace _00_YapilacaklarListesi
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server =. ; database = YapilacaklarDB ; integrated security = true");
        SqlDataAdapter da;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            #region DataTable Orn.
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Ad");
            //dt.Columns.Add("Soyad");
            //dt.Columns.Add("Evli Mi", typeof(bool));

            //dt.Rows.Add("Ali", "Yilmaz",1);
            //dt.Rows.Add("Veli", "Kır",0);
            //dt.Rows.Add("Can", "Yıl",1);
            //dt.Rows.Add("Cem", "Ay",0);

            //dataGridView1.DataSource = dt; 
            #endregion

            YapilacaklariListele();
        }

        private void YapilacaklariListele()
        {
            da = new SqlDataAdapter("Select * from Yapilacaklar", con);
            dt = new DataTable();
            da.Fill(dt);
            var cb = new SqlCommandBuilder(da); //da'nın CRUD islemlerini oluşturur.
            dgvYapilacaklar.DataSource = dt;
        }

        private void btnCheckState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.State.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            da.Update(dt); //datatable üzerindeki yapılmış değişiklikleri db'ye aktar.
        }
    }
}
