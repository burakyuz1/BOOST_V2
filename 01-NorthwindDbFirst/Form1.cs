using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_NorthwindDbFirst
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        Categories cat;
        public Form1()
        {
            InitializeComponent();
            GetCategories();
        }

        private void GetCategories()
        {
            cmbCategories.DataSource = db.Categories.ToList();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex < 0)
            {
                return;
            }
            cat = (Categories)cmbCategories.SelectedItem;
            dgvProducts.DataSource = db.Products.Where(x=>x.CategoryID == cat.CategoryID).ToList();
        }
    }
}
