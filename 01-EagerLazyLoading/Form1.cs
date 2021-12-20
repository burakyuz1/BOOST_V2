using _01_EagerLazyLoading.Data;
using _01_EagerLazyLoading.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_EagerLazyLoading
{
    public partial class Form1 : Form
    {
        AppDbContext db = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
            lstCategories.DataSource = db.Categories.Include(x=>x.Products).ToList();
            lstCategories.DisplayMember = "CategoryName";
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItem == null) return;
            Category category = (Category)lstCategories.SelectedItem;
            //EXPLICIT LOADING : db.Entry(category).Collection(x=>x.Products).Load();
            //Manual olarak lazy loading yapar.
            // HHer kategori değişiminde sorgu gider
            // ihtiyac halinde kullanılılabilir.
            // Cache bellekten ALMAZ, Her defasında güncel veriyi alır.

            dgvProducts.DataSource = category.Products.ToList();
            
        }
    }
}
