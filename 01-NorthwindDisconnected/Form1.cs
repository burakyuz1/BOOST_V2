using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_NorthwindDisconnected
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server = .; database = Northwind; integrated security = true");
        public Form1()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var da = new SqlDataAdapter("SELECT * FROM Categories", con);
            var dt = new DataTable();
            da.Fill(dt);
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvCategories.SelectedRows.Count == 0)
            {
                dgvProducts.DataSource = null;
                return;
            }
            int id = (int)dgvCategories.SelectedRows[0].Cells[0].Value;
            var da = new SqlDataAdapter("SELECT * FROM Products WHERE CategoryId = @p", con);
            da.SelectCommand.Parameters.AddWithValue("@p", id);
            var dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;

        }
    }
}
