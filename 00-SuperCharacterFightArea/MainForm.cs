using _00_SuperCharacterFightArea.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_SuperCharacterFightArea
{
    public partial class MainForm : Form
    {
        SuperCharacterDbContext db = new SuperCharacterDbContext();
        public MainForm()
        {
            InitializeComponent();

            pictureBox1.ImageLocation = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "charDefault.png";

        }

        private void superCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SuperCharacterForm(db).ShowDialog();
        }
    }
}
