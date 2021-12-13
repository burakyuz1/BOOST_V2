using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_AuthorWorkApp
{
    public partial class Form1 : Form
    {
        AuthorWorksDbEntities db = new AuthorWorksDbEntities();
        public Form1()
        {
            InitializeComponent();
            GetAuthors();
            GetWorks();
            GetAuthorImage();
        }

        private void GetWorks()
        {
            lstWorkPanel.DataSource = db.Works.ToList();
            lstWorkPanel.DisplayMember = "Title";
            lstWorkPanel.ValueMember = "WorkId";
            lstWorkPanel.SelectedIndex = -1;
        }

        private void GetAuthorImage()
        {
            if (cmbAuthors.SelectedItem != null && cmbAuthors.SelectedIndex != 0)
            {
                Author author = (Author)cmbAuthors.SelectedItem;
                pcbAuthor.ImageLocation = author.ImageLocation;
                //pcbAuthor.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (cmbAuthors.SelectedIndex == 0)
            {
                pcbAuthor.ImageLocation = "https://img1-kidega.mncdn.com/UPLOAD/blog/large/2019-yilinda-en-cok-okunan-20-yazar.jpg";
            }
        }

        private void GetAuthors()
        {
            cmbAuthors.Items.Clear();
            cmbAuthors.Items.Add("-All Authors-");
            foreach (var item in db.Authors)
            {
                cmbAuthors.Items.Add(item);
            }
            cmbAuthors.DisplayMember = "Name";
            cmbAuthors.ValueMember = "AuthorId";
            cmbAuthors.SelectedIndex = 0;


            cmbWorkAuthors.DataSource = db.Authors.ToList();
            cmbWorkAuthors.DisplayMember = "Name";
            cmbWorkAuthors.ValueMember = "AuthorId";
            cmbWorkAuthors.SelectedIndex = -1;

            lstAuthors.DataSource = db.Authors.ToList();
            lstAuthors.DisplayMember = "Name";
            lstAuthors.ValueMember = "AuthorId";
            lstAuthors.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }



        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAuthorName.Text) && !string.IsNullOrEmpty(txtAuthorName.Text))
            {
                if (btnAddAuthor.Text == "Add")
                {
                    Author author = new Author()
                    {
                        Name = txtAuthorName.Text.Trim(),
                        ImageLocation = txtImageLocation.Text.Trim()
                    };
                    db.Authors.Add(author);
                    db.SaveChanges();
                    MessageBox.Show($"{author.Name} added !");
                    GetAuthors();
                    ClearAuthorPanel();

                }
                else if (btnAddAuthor.Text == "Update")
                {
                    Author authorUpdate = (Author)lstAuthors.SelectedItem;
                    authorUpdate.Name = txtAuthorName.Text.Trim();
                    authorUpdate.ImageLocation = txtImageLocation.Text.Trim();
                    db.Entry(authorUpdate).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    AuthorAdd();
                    GetAuthors();

                }
            }
        }

        private void ClearAuthorPanel()
        {
            txtAuthorName.Clear();
            txtImageLocation.Clear();
        }

        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAuthorImage();
            if (cmbAuthors.SelectedIndex != 0)
            {
                Author author = (Author)cmbAuthors.SelectedItem;
                int authorId = author.AuthorId;

            }
            GetWorks();
        }

        private void lstAuthors_KeyDown(object sender, KeyEventArgs e)
        {
            Author authorDelete = (Author)lstAuthors.SelectedItem;
            if (e.KeyCode == Keys.Delete && lstAuthors.SelectedItems.Count == 1)
            {
                DialogResult dr = MessageBox.Show($"{authorDelete.Name} will be delete. Are you sure about that?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    db.Authors.Remove(authorDelete);
                    db.SaveChanges();
                    GetAuthors();

                }
            }
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitleWork.Text) && !string.IsNullOrEmpty(txtContentWork.Text))
            {


                if (btnAddWork.Text == "Add")
                {
                    Work work = new Work()
                    {
                        Title = txtTitleWork.Text.Trim(),
                        Content = txtContentWork.Text.Trim()
                    };
                    if (cmbWorkAuthors.SelectedIndex != -1)
                    {
                        work.Author = (Author)cmbWorkAuthors.SelectedItem;
                    }
                    db.Works.Add(work);
                    db.SaveChanges();
                    GetWorks();
                    MessageBox.Show($"{work.Title} has been created.");
                    WorkPanelClear();

                }
                else if (btnAddWork.Text == "Update")
                {

                }
            }



        }

        private void WorkPanelClear()
        {
            txtTitleWork.Clear();
            txtContentWork.Clear();
            cmbWorkAuthors.SelectedIndex = -1;
        }

        private void lstAuthors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAuthors.SelectedItems != null)
            {
                AuthorUpdate();
            }
        }

        private void AuthorUpdate()
        {

            grpAuthor.Text = "Update Author";
            btnCancel.Show();
            btnAddAuthor.Text = "Update";
            Author authorUpdate = (Author)lstAuthors.SelectedItem;
            txtAuthorName.Text = authorUpdate.Name;
            txtImageLocation.Text = authorUpdate.ImageLocation;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AuthorAdd();
        }

        private void AuthorAdd()
        {
            grpAuthor.Text = "Add Author";
            btnCancel.Hide();
            btnAddAuthor.Text = "Add";
            ClearAuthorPanel();
        }
    }
}
