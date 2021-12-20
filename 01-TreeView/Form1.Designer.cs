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
            this.trwPlaces = new System.Windows.Forms.TreeView();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trwPlaces
            // 
            this.trwPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trwPlaces.Location = new System.Drawing.Point(12, 12);
            this.trwPlaces.Name = "trwPlaces";
            this.trwPlaces.Size = new System.Drawing.Size(451, 426);
            this.trwPlaces.TabIndex = 0;
            this.trwPlaces.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trwPlaces_AfterSelect);
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(582, 148);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(158, 20);
            this.txtPlaceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Place Name:";
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Location = new System.Drawing.Point(665, 192);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlace.TabIndex = 3;
            this.btnAddPlace.Text = "Add";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(582, 114);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.ReadOnly = true;
            this.txtParentName.Size = new System.Drawing.Size(158, 20);
            this.txtParentName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parent:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.trwPlaces);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trwPlaces;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPlace;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label label2;
    }
}

