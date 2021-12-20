using _00_SuperCharacterFightArea.Data;
using _00_SuperCharacterFightArea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_SuperCharacterFightArea
{
    public partial class SuperCharacterForm : Form
    {
        private readonly SuperCharacterDbContext db;

        public SuperCharacterForm(SuperCharacterDbContext db)
        {
            InitializeComponent();
            this.db = db;
            pboCharImage.SizeMode = PictureBoxSizeMode.StretchImage;
            LoadSuperChars();
        }

        private void LoadSuperChars()
        {
            lstSuperCharacters.DataSource = db.SuperCharacters.ToList();
            //TODO: Include Ability XD
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop), //filedialog açılacağı konum masaüstü oldu.
                Filter = "Image Files |*.jpg;*.jpeg;*.png;",
                Title = "Choose Image For Super Character"
            };
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Bitmap bitmap = new Bitmap(filePath);

                string ext = Path.GetExtension(filePath); // adamın seçtiği image'ın uzantasını verir.
                string imagePath = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + Guid.NewGuid().ToString() + ext;


                bitmap.Save(imagePath);
                pboCharImage.ImageLocation = imagePath;
                txtImagePath.Text = imagePath;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCharName.Text))
            {
                SuperCharacter superCharacter = new SuperCharacter()
                {
                    Name = txtCharName.Text,
                    Health = (int)nmuHealth.Value,
                    IsAlive = chkIsAlvie.Checked
                };
                if(!string.IsNullOrEmpty(pboCharImage.ImageLocation))
                {
                    superCharacter.ImagePath= pboCharImage.ImageLocation;
                }
                db.SuperCharacters.Add(superCharacter);
                db.SaveChanges();
                LoadSuperChars();
                ClearItems();
            }
        }

        private void ClearItems()
        {

            txtCharName.Text = "";
            nmuHealth.Value = 100;
            chkIsAlvie.Checked = true;
            txtImagePath.Text = "";
            pboCharImage.ImageLocation = "";

        }

        private void btnAbility_Click(object sender, EventArgs e)
        {
            if(lstSuperCharacters.SelectedItems.Count > 0)
            {
                SuperCharacter superCharacter = (SuperCharacter)lstSuperCharacters.SelectedItem;
                AbilityForm abilityForm = new AbilityForm(db,superCharacter);
                abilityForm.ShowDialog();
            }
        }
    }
}
