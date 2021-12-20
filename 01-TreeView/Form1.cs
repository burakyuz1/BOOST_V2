using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TreeView
{
    public partial class Form1 : Form
    {
        TreeViewDbContext db = new TreeViewDbContext();
        Place selectedPlace = null;
        public Form1()
        {
            InitializeComponent();
            GetWorldsChildren();
        }

        private void GetWorldsChildren()
        {
            trwPlaces.Nodes.Clear();
            Place world = db.Places.FirstOrDefault(x => x.Name == "World");
            AddPlace(world, trwPlaces.Nodes);
            trwPlaces.ExpandAll();
        }

        /// <summary>
        /// Bu metot, parametre olarak aldığı yeri bir düğüme dönüştürerek
        /// yine parametre olarak aldığı duğumler adındaki koleksiyona ekler.</summary>
        /// <param name="place">düğüm koleksiyonuna eklenmek istenen yer</param>
        /// <param name="nodes">yeni düğümün ekleneceği düğümler koleksiyonu</param>
        private void AddPlace(Place place, TreeNodeCollection nodes)
        {
            TreeNode tn = new TreeNode(place.Name);
            tn.Tag = place;
            
            foreach (Place downPlace in place.Children)
            {
                AddPlace(downPlace, tn.Nodes);
            }

            nodes.Add(tn);
        }

        private void trwPlaces_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtParentName.Text = e.Node.Text;
            selectedPlace = (Place)e.Node.Tag;
        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
           // if (string.IsNullOrEmpty(txtPlaceName.Text)) return;

            string placeName = txtPlaceName.Text;

            Place place = new Place(placeName);
            selectedPlace.Children.Add(place);
            db.SaveChanges();
            GetWorldsChildren();

        }
    }
}
