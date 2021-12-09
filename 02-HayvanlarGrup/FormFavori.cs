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
    public partial class FormFavori : Form
    {
        private readonly int yiyecekId;
        private readonly SqlConnection con;
        SqlCommand cmd;
        public FormFavori(int yiyecekId, SqlConnection con)
        {
            InitializeComponent();
            this.yiyecekId = yiyecekId;
            this.con = con;
            HayvanlariGetir();
            FavoriYiyecekGetir(yiyecekId);
        }

        private void FavoriYiyecekGetir(int yiyecekId)
        {
            cmd = new SqlCommand("SELECT Ad FROM Yiyecekler Where yiyecekId = @p", con);
            cmd.Parameters.AddWithValue("@p", yiyecekId);
            var dr = cmd.ExecuteReader(); 
            if(dr.Read())
            {
                lblFavoriYiyecek.Text = $"\"{(string)dr[0]}\"\n SEVEN HAYVANLAR";
            }
            dr.Close();
        }

        private void HayvanlariGetir()
        {
            cmd = new SqlCommand("cp_hayvanByFavoriYiyecek", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@favoriId", yiyecekId));
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lstHayvanlar.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
