using _00_CareTaker.Context;
using _00_CareTaker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_CareTaker
{
    public partial class FormAssignCareTaker : Form
    {
        private readonly CareTakerDbContext db;
        private readonly Pet pet;

        public FormAssignCareTaker(CareTakerDbContext db, Pet pet)
        {
            this.db = db;
            this.pet = pet;
            InitializeComponent();
            GetTakers();
        }

        private void GetTakers()
        {
            lstCareTakers.DisplayMember = "FirstName";
            lstCareTakers.DataSource = db.CareTakers.ToList();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            CareTaker ct = (CareTaker)lstCareTakers.SelectedItem;
            pet.CareTakers.Add(ct);
            db.SaveChanges();
            MessageBox.Show("Successfully!");
            GetTakers();
        }
    }
}
