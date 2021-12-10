using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_NorthwindDbFirst2
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
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
            if (cmbCategories.SelectedItem == null)
            {
                dgvProducts.DataSource = null;
                return;
            }

            Category category = (Category)cmbCategories.SelectedItem;
            dgvProducts.DataSource = category.Products.ToList();

        }
    }
}
