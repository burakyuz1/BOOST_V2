using _01_MigrationExcercises.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _01_MigrationExcercises
{
    public partial class Form1 : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Form1()
        {
            InitializeComponent();
            dgvKisiler.DataSource = db.People.ToList();
            //LoadSampleData();
        }

        private void LoadSampleData()
        {
            List<Person> people = null;
            if (!db.People.Any())
            {
                people = new List<Person>()
                {
                    new Person()
                    {
                        Name= "Burak"
                    },
                    new Person()
                    {
                        Name= "Bilgehan"
                    },
                };
            }
            dgvKisiler.DataSource = people;
        }
    }
}
