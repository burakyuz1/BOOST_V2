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

namespace _00_DcChinook
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server = .; database = Chinook; integrated security = true");
        SqlDataAdapter da;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        DataTable dt;
        DataTable dt1;
        DataTable dt2;
        public Form1()
        {
            InitializeComponent();
            GetArtists();
        }

        private void GetArtists()
        {
            da = new SqlDataAdapter("SELECT * FROM Artist", con);
            dt = new DataTable();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            dgvArtists.DataSource = dt;
        }

        private void dgvArtists_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArtists.SelectedRows.Count != 1)
            {
                dgvAlbums.DataSource = null;
                dgvTracks.DataSource = null;
                return;
            }
            int artistId = 0;
            try
            {
                artistId = (int)dgvArtists.SelectedRows[0].Cells[0].Value;

            }
            catch (Exception)
            {

                MessageBox.Show("box geçemezsin");
                return;
            }
            da1 = new SqlDataAdapter("SELECT * FROM Album WHERE ArtistId = @p", con);
            da1.SelectCommand.Parameters.AddWithValue("@p", artistId);
            dt1 = new DataTable();
            SqlCommandBuilder cb = new SqlCommandBuilder(da1);
            da1.Fill(dt1);
            dgvAlbums.DataSource = dt1;

        }

        private void dgvAlbums_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlbums.SelectedRows.Count != 1)
            {
                dgvTracks.DataSource = null;
                return;
            }
            int albumId = (int)dgvAlbums.SelectedRows[0].Cells[0].Value;
            da2 = new SqlDataAdapter("SELECT * FROM Track WHERE AlbumId = @p", con);
            da2.SelectCommand.Parameters.AddWithValue("@p", albumId);
            dt2 = new DataTable();
            SqlCommandBuilder cb = new SqlCommandBuilder(da2);
            da2.Fill(dt2);
            dgvTracks.DataSource = dt2;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            da.Update(dt);
            da1.Update(dt1);
            da2.Update(dt2);
        }

 
    }
}
