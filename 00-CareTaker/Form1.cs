using _00_CareTaker.Context;
using _00_CareTaker.Enums;
using _00_CareTaker.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _00_CareTaker
{
    public partial class Form1 : Form
    {
        CareTakerDbContext db = new CareTakerDbContext();
        public Form1()
        {
            InitializeComponent();
            GetFoods();
            GetPets();
        }

        private void GetPets()
        {
            lstPets.DisplayMember = "Name";
            lstPets.DataSource = db.Pets.ToList();
        }

        private void GetFoods()
        {
            lstFoods.DisplayMember = "Name";
            lstFoods.DataSource = db.Foods.ToList();
            cmbFavourite.DisplayMember = "Name";
            cmbFavourite.DataSource = db.Foods.ToList();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string foodName = txtFood.Text;
            decimal cal = nmuCalorie.Value;
            DateTime sopDate = dtpSop.Value;
            DateTime exDate = dtpExpire.Value;

            Food food = new Food()
            {
                Name = foodName,
                Calorie = cal,
                ExpirationDate = exDate,
                ProductionDate = sopDate
            };
            if (food == null) return;

            db.Foods.Add(food);
            db.SaveChanges();
            GetFoods();

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            string petName = txtName.Text;
            double weight = (double)nmuWeight.Value;
            string type = txtType.Text;
            bool hasOwner = (chbHasOwner.Checked) ? true : false;
            DateTime dtBirth = dtpDateOfBirth.Value;
            Gender gender;

            if (rdoMale.Checked)
                gender = Gender.Male;
            else if (rdoFemale.Checked)
                gender = Gender.Female;
            else
                gender = Gender.Nothing;

            Food favFood = (Food)cmbFavourite.SelectedItem;

            Pet pet = new Pet()
            {
                Name = petName,
                Gender = gender,
                HasOwner = hasOwner,
                BirthDate = dtBirth,
                Type = type,
                Weight = weight,
                Food = favFood
            };

            db.Pets.Add(pet);
            db.SaveChanges();
            GetPets();
        }

        private void btnTakerAdd_Click(object sender, EventArgs e)
        {
            string takerName = txtTakerName.Text;
            string TakerSurname = txtLastName.Text;

            CareTaker ct = new CareTaker()
            {
                FirstName = takerName,
                LastName = TakerSurname
            };

            db.CareTakers.Add(ct);
            db.SaveChanges();
            GetCareTakers();


        }

        private void GetCareTakers()
        {
            lstTakers.DisplayMember = "FirstName";
            //TODO: display member will be name + surname
            lstTakers.DataSource = db.CareTakers.ToList();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Pet editedPet = (Pet)lstPets.SelectedItem;
            FormAssignCareTaker fct = new FormAssignCareTaker(db,editedPet);
            fct.ShowDialog();
        }
    }
}
