using _04_EfCfCRUD_Islemleri.Model;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_EfCfCRUD_Islemleri
{
    public partial class Form1 : MetroForm
    {
        DailyContext db = new DailyContext();
        public Form1()
        {
            InitializeComponent();
            GetEntries();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstEntries.SelectedItem == null) return;
            string title = txtTitle.Text.Trim();
            string content = txtContent.Text.Trim();
            DateTime time = DateTime.Now;

            if (title == "")
                MetroMessageBox.Show(this, "Please fill the title", "Error", 100);

            Entry entry = (Entry)lstEntries.SelectedItem;
            entry.Title = title;
            entry.Content = content;
            entry.Time = DateTime.Now;
            db.SaveChanges();
            //GetEntries();
            lstEntries.DisplayMember = "";
            lstEntries.DisplayMember = "Title";
            lblTime.Text = entry.Time.ToString();
        }

        private void GetEntries()
        {
            lstEntries.DataSource = db.Entries.OrderByDescending(x => x.Time).ToList();
            lstEntries.DisplayMember = "Title";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.Entries.Add(new Entry() { Title = "New Entry" });
            db.SaveChanges();
            GetEntries();
        }

        private void lstEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEntries.SelectedIndex < 0)
            {
                txtContent.Clear();
                txtTitle.Clear();
                lblTime.Text = "Time: ";
                return;
            }

            Entry entry = (Entry)lstEntries.SelectedItem;
            txtTitle.Text = entry.Title;
            txtContent.Text = entry.Content;
            lblTime.Text = "Time: " + entry.Time;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEntries.SelectedIndex < 0) return;
            Entry entry = (Entry)lstEntries.SelectedItem;
            db.Entries.Remove(entry);
            db.SaveChanges();
            GetEntries();
        }
    }
}
