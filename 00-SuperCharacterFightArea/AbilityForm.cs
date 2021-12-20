using _00_SuperCharacterFightArea.Data;
using _00_SuperCharacterFightArea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_SuperCharacterFightArea
{
    public partial class AbilityForm : Form
    {
        private readonly SuperCharacterDbContext db;
        private readonly SuperCharacter superCharacter;

        public AbilityForm(SuperCharacterDbContext db , SuperCharacter superCharacter)
        {
            InitializeComponent();
            this.db = db;
            this.superCharacter = superCharacter;
            LoadAbilities();
        }

        private void LoadAbilities()
        {
            pictureBox1.ImageLocation = superCharacter.ImagePath;
        }
    }
}
