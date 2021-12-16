namespace _01_TreeView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Abidinpaşa");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tuzluçayır");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Natoyolu");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mamak", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Bilkent");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Çankaya", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ankara", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Türkiye", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(148, 43);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Abidinpaşa";
            treeNode2.Name = "Node6";
            treeNode2.Text = "Tuzluçayır";
            treeNode3.Name = "Node7";
            treeNode3.Text = "Natoyolu";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Mamak";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Bilkent";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Çankaya";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Ankara";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Türkiye";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(413, 276);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

