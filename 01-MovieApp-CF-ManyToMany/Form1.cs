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
    public partial class Form1 : Form
    {
        MovieAppDbContext db = new MovieAppDbContext();
        Movie selectedMovie = null;
        Genre selectedGenre = null;
        public Form1()
        {
            SeedData();
            InitializeComponent();
            LoadGenres();
        }

        private void LoadGenres()
        {
            cmbGenres.DisplayMember = "Name";
            cmbGenres.DataSource = db.Genres.OrderBy(x => x.Name).ToList();
            cmbGenres.SelectedItem = selectedGenre;
        }

        private void SeedData()
        {
            if (!db.Genres.Any() && !db.Movies.Any())
            {
                string[] genres = { "Drama", "Adventure", "Action", "Thriller", "Comedy", "Sci-Fi", "War", "Crime", "Horror", "History", "Romance", "Biography", "Fantasy", "Western", "Family", "Musical", "Mystery", "Animation", "Documentary", "Film-Noir", "Music", "Sport" };

                foreach (string genre in genres)
                {
                    db.Genres.Add(new Genre() { Name = genre });
                    db.SaveChanges();
                }

                Genre drama = db.Genres.FirstOrDefault(x => x.Name == "Drama");
                Genre romance = db.Genres.FirstOrDefault(x => x.Name == "Romance");
                Genre adventure = db.Genres.FirstOrDefault(x => x.Name == "Adventure");
                Genre comedy = db.Genres.FirstOrDefault(x => x.Name == "Comedy");
                Genre scifi = db.Genres.FirstOrDefault(x => x.Name == "Sci-Fi");
                Genre horror = db.Genres.FirstOrDefault(x => x.Name == "Horror");
                Genre mystery = db.Genres.FirstOrDefault(x => x.Name == "Mystery");
                Genre action = db.Genres.FirstOrDefault(x => x.Name == "Action");
                Genre history = db.Genres.FirstOrDefault(x => x.Name == "History");
                Genre biography = db.Genres.FirstOrDefault(x => x.Name == "Biography");
                Genre crime = db.Genres.FirstOrDefault(x => x.Name == "Crime");
                Genre fantasy = db.Genres.FirstOrDefault(x => x.Name == "Fantasy");

                db.Movies.Add(new Movie()
                {
                    Title = "Titanic",
                    Year = 1997,
                    Rating = 7.8m,
                    Genres = new[] { drama, romance }
                });

                db.Movies.Add(new Movie()
                {
                    Title = "Back to the Future 1",
                    Year = 1985,
                    Rating = 8.5m,
                    Genres = new[] { adventure, comedy, scifi }
                });

                db.Movies.Add(new Movie()
                {
                    Title = "Borgman",
                    Year = 2013,
                    Rating = 6.8m,
                    Genres = new[] { drama, horror, mystery }
                });
                db.Movies.Add(new Movie()
                {
                    Title = "Pearl Horbour",
                    Year = 2001,
                    Rating = 6.8m,
                    Genres = new[] { drama, action, history }
                });
                db.Movies.Add(new Movie()
                {
                    Title = "The wolf of wolfstreet",
                    Year = 2013,
                    Rating = 8.2m,
                    Genres = new[] { biography, crime, comedy }
                });
                db.Movies.Add(new Movie()
                {
                    Title = "Parfume: The Story of a Murderer",
                    Year = 2006,
                    Rating = 7.5m,
                    Genres = new[] { crime, drama, fantasy }
                });

                db.SaveChanges();

            }
        }

        private void cmbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre genre = (Genre)cmbGenres.SelectedItem;
            if (genre == null)
            {
                dgvMovies.DataSource = null;
                return;
            }
            dgvMovies.DataSource = genre.Movies.Select
                (
                m => new
                {
                    m.Id,
                    m.Title,
                    m.Year,
                    m.Rating,
                    Genres = string.Join(", ", m.Genres.Select(g => g.Name))
                }
                ).ToList();
            if (selectedMovie != null)
                foreach (DataGridViewRow row in dgvMovies.Rows)
                    if ((int)row.Cells[0].Value == selectedMovie.Id)
                        row.Selected = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
                return;



            int id = (int)dgvMovies.SelectedRows[0].Cells[0].Value;
            Movie movie = db.Movies.Find(id);
            //first or default / where kullanabilirdik.
            selectedMovie = movie;
            selectedGenre = (Genre)cmbGenres.SelectedItem;



            DialogResult dr = new EditMovieForm(db, movie).ShowDialog();
                selectedMovie = movie;
                selectedGenre = movie.Genres.FirstOrDefault();

            if (dr == DialogResult.OK)
            {
                if (!movie.Genres.Contains(selectedGenre))
                    selectedGenre = movie.Genres.FirstOrDefault();
                LoadGenres();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie(){ Genres = new List<Genre>()};// buradan devam
            DialogResult dr = new EditMovieForm(db, newMovie).ShowDialog();

            if (dr == DialogResult.OK)
            {
                selectedGenre = newMovie.Genres.FirstOrDefault();
                selectedMovie = newMovie;
                LoadGenres();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
                return;
            int id = (int)dgvMovies.SelectedRows[0].Cells[0].Value;
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            selectedGenre = (Genre)cmbGenres.SelectedItem;
            LoadGenres();
        }

    }
}
