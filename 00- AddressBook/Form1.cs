using _00__AddressBook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00__AddressBook
{
    public partial class Form1 : Form
    {
        AddressBookDbContext db = new AddressBookDbContext();
        public Form1()
        {
            InitializeComponent();
            GetPerson();
        }

        private void GetPerson()
        {
            dgvPeople.DataSource = db.People.ToList();
        }
    }
}
