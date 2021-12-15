using _01_MovieApp_CF_ManyToMany.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MovieApp_CF_ManyToMany
{
    public partial class EditMovieForm : Form
    {
        private readonly MovieAppDbContext db;
        private readonly Movie movie;

        public EditMovieForm(MovieAppDbContext db, Movie movie)
        {
            this.db = db;
            this.movie = movie;
            InitializeComponent();
            clbGenres.DataSource = db.Genres.OrderBy(x => x.Name).ToList();
            clbGenres.DisplayMember = "Name";
            if (movie.Id > 0)
            {
                Text = "Editing: \"" + movie.Title + "\"";
                txtTitle.Text = movie.Title;
                nmuRating.Value = movie.Rating;
                nmuYear.Value = movie.Year;
                for (int i = 0; i < clbGenres.Items.Count; i++)
                {
                    Genre genre = (Genre)clbGenres.Items[i];
                    //if (movie.Genres.Contains(genre)) 
                    //{
                    // bir diğer yöntem, farklı db context olsa burası patlar.
                    //}
                    if (movie != null && movie.Genres.Any(x => x.Movies == genre.Movies))
                        clbGenres.SetItemChecked(i, true);
                }
            }
            else
            {
                Text = "New Movie";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            int year = (int)nmuYear.Value;
            decimal rating = nmuRating.Value;
            if (title == "")
            {
                MessageBox.Show("You can not pass title empty!");
                return;
            }
            if (clbGenres.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must choose at least 1 genre");
                return;
            }
            movie.Title = title;
            movie.Year = year;
            movie.Rating = rating;
            movie.Genres.Clear();
            foreach (Genre genre in clbGenres.CheckedItems)
                movie.Genres.Add(genre);

            if (movie.Id == 0)
                db.Movies.Add(movie);

            db.SaveChanges();
            DialogResult = DialogResult.OK;

        }
    }
}
