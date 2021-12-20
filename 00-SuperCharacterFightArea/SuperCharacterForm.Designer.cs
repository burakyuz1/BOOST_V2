namespace _00_SuperCharacterFightArea
{
    partial class SuperCharacterForm
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
            this.lstSuperCharacters = new System.Windows.Forms.ListBox();
            this.pboCharImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.chkIsAlvie = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.nmuHealth = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAbility = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboCharImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSuperCharacters
            // 
            this.lstSuperCharacters.FormattingEnabled = true;
            this.lstSuperCharacters.Location = new System.Drawing.Point(19, 17);
            this.lstSuperCharacters.Name = "lstSuperCharacters";
            this.lstSuperCharacters.Size = new System.Drawing.Size(329, 420);
            this.lstSuperCharacters.TabIndex = 0;
            // 
            // pboCharImage
            // 
            this.pboCharImage.Location = new System.Drawing.Point(365, 17);
            this.pboCharImage.Name = "pboCharImage";
            this.pboCharImage.Size = new System.Drawing.Size(423, 151);
            this.pboCharImage.TabIndex = 1;
            this.pboCharImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Path:";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(432, 185);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(275, 20);
            this.txtImagePath.TabIndex = 3;
            // 
            // chkIsAlvie
            // 
            this.chkIsAlvie.AutoSize = true;
            this.chkIsAlvie.Location = new System.Drawing.Point(445, 288);
            this.chkIsAlvie.Name = "chkIsAlvie";
            this.chkIsAlvie.Size = new System.Drawing.Size(113, 17);
            this.chkIsAlvie.TabIndex = 4;
            this.chkIsAlvie.Text = "Is character alive?";
            this.chkIsAlvie.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(713, 183);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Health";
            // 
            // txtCharName
            // 
            this.txtCharName.Location = new System.Drawing.Point(432, 216);
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(275, 20);
            this.txtCharName.TabIndex = 6;
            // 
            // nmuHealth
            // 
            this.nmuHealth.Location = new System.Drawing.Point(432, 248);
            this.nmuHealth.Name = "nmuHealth";
            this.nmuHealth.Size = new System.Drawing.Size(275, 20);
            this.nmuHealth.TabIndex = 7;
            this.nmuHealth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(432, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(536, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(632, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAbility
            // 
            this.btnAbility.Location = new System.Drawing.Point(632, 368);
            this.btnAbility.Name = "btnAbility";
            this.btnAbility.Size = new System.Drawing.Size(156, 69);
            this.btnAbility.TabIndex = 11;
            this.btnAbility.Text = "Ability";
            this.btnAbility.UseVisualStyleBackColor = true;
            this.btnAbility.Click += new System.EventHandler(this.btnAbility_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(365, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // SuperCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAbility);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nmuHealth);
            this.Controls.Add(this.txtCharName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.chkIsAlvie);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboCharImage);
            this.Controls.Add(this.lstSuperCharacters);
            this.Name = "SuperCharacterForm";
            this.Text = "SuperCharacterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboCharImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuHealth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSuperCharacters;
        private System.Windows.Forms.PictureBox pboCharImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.CheckBox chkIsAlvie;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCharName;
        private System.Windows.Forms.NumericUpDown nmuHealth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAbility;
        private System.Windows.Forms.Button btnDelete;
    }
}