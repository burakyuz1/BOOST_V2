using _02_SingerApp.Context;
using _02_SingerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_SingerApp
{
    public partial class Form1 : Form
    {
        SingersDb db = new SingersDb();
        public Form1()
        {
            InitializeComponent();
            GetAllNations();
            GetAllSingers();
        }

        private void GetAllSingers()
        {
            lstSingers.DataSource = db.Singers.ToList();
        }

        private void GetAllNations()
        {
            cmbSingerAddNations.DisplayMember = "Nationality";
            var nationalityList = db.Nations.ToList();
            nationalityList.Insert(0, new Nation() { Nationality = "All nations" });
            cmbSingerAddNations.DataSource = nationalityList;
            lstNationsAdd.DisplayMember = "Nationality";
            lstNationsAdd.DataSource = db.Nations.ToList();
        }

        private void btnNationAdd_Click(object sender, EventArgs e)
        {
            string nationality = txtNationAddName.Text.Trim();
            if (nationality == "")
            {
                MessageBox.Show("Nationality can not pass empty !");
                return;
            }

            Nation nation = new Nation()
            {
                Nationality = nationality
            };
            db.Nations.Add(nation);
            db.SaveChanges();
            GetAllNations();
            txtNationAddName.Clear();
            txtNationAddName.Focus();
        }

        private void btnNationUpdate_Click(object sender, EventArgs e)
        {
            Nation nationUpdate = (Nation)lstNationsAdd.SelectedItem;
            if (nationUpdate == null)
            {
                MessageBox.Show("Please choose a nationality");
                return;
            }
            btnNationAdd.Enabled = false;
            btnNationRemove.Enabled = false;
            if (btnNationUpdate.Text == "Update")
            {
                txtNationAddName.Text = nationUpdate.Nationality;
                btnCancel.Show();
                btnNationUpdate.Text = "Save";
            }
            else
            {
                nationUpdate.Nationality = txtNationAddName.Text.Trim();

                db.SaveChanges();
                GetAllNations();
                ReturnButtonsToReverse();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnButtonsToReverse();
        }

        private void ReturnButtonsToReverse()
        {
            btnCancel.Hide();
            btnNationUpdate.Text = "Update";
            txtNationAddName.Clear();
            btnNationAdd.Enabled = true;
            btnNationRemove.Enabled = true;
        }

        private void btnNationRemove_Click(object sender, EventArgs e)
        {
            Nation deletedNation = (Nation)lstNationsAdd.SelectedItem;
            if (deletedNation == null) return;
            DialogResult dr = MessageBox.Show($"Are you sure that you will delete {deletedNation.Nationality} nationality?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db.Nations.Remove(deletedNation);
                db.SaveChanges();
                GetAllNations();
            }
        }

        private void btnAddSinger_Click(object sender, EventArgs e)
        {
            string singerName = txtSingerAddName.Text.Trim();
            if (singerName == "" && cmbSingerAddNations.SelectedIndex < 1)
            {
                MessageBox.Show("Error, please choose a nationality and fill the name area.");
                return;
            }
            Nation nation = (Nation)cmbSingerAddNations.SelectedItem;
            Singer singer = new Singer()
            {
                Nation = nation,
                SingerName = singerName
            };
            db.Singers.Add(singer);
            db.SaveChanges();
            GetAllSingers();
            txtSingerAddName.Clear();
            cmbSingerAddNations.SelectedIndex = -1;

        }

        private void btnUpdateSinger_Click(object sender, EventArgs e)
        {
            Singer singer = (Singer)lstSingers.SelectedItem;
            if (singer == null) return;
            btnAddSinger.Enabled = false;
            btnRemoveSinger.Enabled = false;
            if (btnUpdateSinger.Text == "Update")
            {
                txtSingerAddName.Text = singer.SingerName;
                cmbSingerAddNations.SelectedItem = singer.Nation;
                btnCancelSinger.Show();
                btnUpdateSinger.Text = "Save";
            }
            else //save
            {
                singer.SingerName = txtSingerAddName.Text.Trim();
                singer.Nation = (Nation)cmbSingerAddNations.SelectedItem;
                db.SaveChanges();
                GetAllSingers();
                btnAddSinger.Enabled = true;
                btnRemoveSinger.Enabled = true;
                btnCancelSinger.Hide();
                btnUpdateSinger.Text = "Update";
                txtSingerAddName.Clear();
            }
        }

        private void btnCancelSinger_Click(object sender, EventArgs e)
        {
            btnAddSinger.Enabled = true;
            btnRemoveSinger.Enabled = true;
            txtSingerAddName.Clear();
            lstSingers.SelectedIndex = -1;
            btnCancelSinger.Hide();
            cmbSingerAddNations.SelectedIndex = -1;
            btnUpdateSinger.Text = "Update";
        }

        private void btnRemoveSinger_Click(object sender, EventArgs e)
        {
            Singer singer = (Singer)lstSingers.SelectedItem;
            if (singer == null) return;
            db.Singers.Remove(singer);
            db.SaveChanges();
            GetAllSingers();
        }

        private void cmbSingerAddNations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nation nation = (Nation)cmbSingerAddNations.SelectedItem;
            lstSingers.DisplayMember = "SingerName";
            if (nation == null && cmbSingerAddNations.SelectedIndex < 1) return;
            if(cmbSingerAddNations.SelectedIndex == 0)
            {
                GetAllSingers();
                return;
            }
            lstSingers.DataSource = nation.Singers?.ToList();
        }
    }
}
