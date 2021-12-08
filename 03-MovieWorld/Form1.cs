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

namespace _03_MovieWorld
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=. ; database = IMDB ; uid=sa ; pwd = 123");
        List<Movie> movies;
        Movie edited;
        public Form1()
        {
            con.Open();
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            string search = txtSearch.Text.Trim();

            SqlCommand cmd = new SqlCommand("SELECT Id, Title, Year, Rating FROM Movies", con);
            if (search != string.Empty)
            {
                cmd.CommandText += " WHERE Title LIKE @p1 OR Year LIKE @p1";
                cmd.Parameters.AddWithValue("@p1", "%" + search + "%");
            }
            SqlDataReader dr = cmd.ExecuteReader();
            movies = new List<Movie>();
            while (dr.Read())
            {
                movies.Add(new Movie()
                {
                    Id = dr.GetInt32(0),
                    Title = dr.GetString(1),
                    Year = dr.GetInt32(2),
                    Rating = dr.GetDecimal(3)
                });
            }
            dr.Close();
            dgvMovies.DataSource = movies;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            string title = txtTitle.Text.Trim();
            int year = (int)nmuYear.Value;
            decimal rating = nmuRating.Value;
            if (title == "")
            {

                MessageBox.Show("Title is required!");
                return;
            }
            #endregion
            #region Update/Add

            if (edited == null)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Movies(Title, Year, Rating) VALUES (@p1, @p2,@p3)", con);
                cmd.Parameters.AddWithValue("@p1", title);
                cmd.Parameters.AddWithValue("@p2", year);
                cmd.Parameters.AddWithValue("@p3", rating);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Movies SET Title = @p1, Year = @p2 , Rating = @p3  WHERE Id = @p4", con);
                cmd.Parameters.AddWithValue("@p1", title);
                cmd.Parameters.AddWithValue("@p2", year);
                cmd.Parameters.AddWithValue("@p3", rating);
                cmd.Parameters.AddWithValue("@p4", edited.Id);
                cmd.ExecuteNonQuery();

            }
            #endregion
            ResetForm();
            LoadMovies();

        }

        private void ResetForm()
        {
            edited = null;
            btnAdd.Text = "ADD";
            btnCancel.Hide();
            txtTitle.Text = "";
            nmuRating.Value = 10.0m;
            nmuYear.Value = 2000;
            dgvMovies.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count != 1) return;

            Movie movie = (Movie)dgvMovies.SelectedRows[0].DataBoundItem;

            SqlCommand cmd = new SqlCommand("Delete FROM Movies Where Id = @p", con);
            cmd.Parameters.AddWithValue("@p", movie.Id);
            cmd.ExecuteNonQuery();
            LoadMovies();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count != 1) return;
            edited = (Movie)dgvMovies.SelectedRows[0].DataBoundItem;
            btnAdd.Text = "SAVE";
            btnCancel.Show();
            txtTitle.Text = edited.Title;
            nmuRating.Value = edited.Rating;
            nmuYear.Value = edited.Year;
            dgvMovies.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }
    }
}
