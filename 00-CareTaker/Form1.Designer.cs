namespace _00_CareTaker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nmuCalorie = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExpire = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSop = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lstFoods = new System.Windows.Forms.ListBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cmbFavourite = new System.Windows.Forms.ComboBox();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.lstPets = new System.Windows.Forms.ListBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.nmuWeight = new System.Windows.Forms.NumericUpDown();
            this.rdoNothing = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.chbHasOwner = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstTakers = new System.Windows.Forms.ListBox();
            this.btnTakerAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTakerName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuCalorie)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuWeight)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvList);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Size = new System.Drawing.Size(816, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(8, 87);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(805, 307);
            this.dgvList.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nmuCalorie);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpExpire);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpSop);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnAddFood);
            this.tabPage1.Controls.Add(this.lstFoods);
            this.tabPage1.Controls.Add(this.txtFood);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Size = new System.Drawing.Size(816, 465);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Food";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nmuCalorie
            // 
            this.nmuCalorie.DecimalPlaces = 1;
            this.nmuCalorie.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmuCalorie.Location = new System.Drawing.Point(114, 250);
            this.nmuCalorie.Name = "nmuCalorie";
            this.nmuCalorie.Size = new System.Drawing.Size(120, 29);
            this.nmuCalorie.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Expire date";
            // 
            // dtpExpire
            // 
            this.dtpExpire.Location = new System.Drawing.Point(114, 174);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.Size = new System.Drawing.Size(200, 29);
            this.dtpExpire.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "SOP Date";
            // 
            // dtpSop
            // 
            this.dtpSop.Location = new System.Drawing.Point(114, 102);
            this.dtpSop.Name = "dtpSop";
            this.dtpSop.Size = new System.Drawing.Size(200, 29);
            this.dtpSop.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(630, 30);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(213, 322);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(101, 29);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lstFoods
            // 
            this.lstFoods.FormattingEnabled = true;
            this.lstFoods.ItemHeight = 24;
            this.lstFoods.Location = new System.Drawing.Point(409, 30);
            this.lstFoods.Name = "lstFoods";
            this.lstFoods.Size = new System.Drawing.Size(202, 292);
            this.lstFoods.TabIndex = 2;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(112, 31);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(202, 29);
            this.txtFood.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtpDateOfBirth);
            this.tabPage3.Controls.Add(this.btnAssign);
            this.tabPage3.Controls.Add(this.cmbFavourite);
            this.tabPage3.Controls.Add(this.btnAddPet);
            this.tabPage3.Controls.Add(this.lstPets);
            this.tabPage3.Controls.Add(this.txtType);
            this.tabPage3.Controls.Add(this.nmuWeight);
            this.tabPage3.Controls.Add(this.rdoNothing);
            this.tabPage3.Controls.Add(this.rdoFemale);
            this.tabPage3.Controls.Add(this.rdoMale);
            this.tabPage3.Controls.Add(this.chbHasOwner);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtName);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Size = new System.Drawing.Size(816, 465);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Pet";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(121, 381);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 29);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(572, 356);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(219, 31);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "Assign Care Taker";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cmbFavourite
            // 
            this.cmbFavourite.FormattingEnabled = true;
            this.cmbFavourite.Location = new System.Drawing.Point(98, 314);
            this.cmbFavourite.Name = "cmbFavourite";
            this.cmbFavourite.Size = new System.Drawing.Size(192, 32);
            this.cmbFavourite.TabIndex = 10;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(318, 314);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(109, 36);
            this.btnAddPet.TabIndex = 9;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // lstPets
            // 
            this.lstPets.FormattingEnabled = true;
            this.lstPets.ItemHeight = 24;
            this.lstPets.Location = new System.Drawing.Point(445, 34);
            this.lstPets.Name = "lstPets";
            this.lstPets.Size = new System.Drawing.Size(346, 316);
            this.lstPets.TabIndex = 8;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(99, 262);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(191, 29);
            this.txtType.TabIndex = 7;
            // 
            // nmuWeight
            // 
            this.nmuWeight.Location = new System.Drawing.Point(99, 201);
            this.nmuWeight.Name = "nmuWeight";
            this.nmuWeight.Size = new System.Drawing.Size(120, 29);
            this.nmuWeight.TabIndex = 6;
            // 
            // rdoNothing
            // 
            this.rdoNothing.AutoSize = true;
            this.rdoNothing.Location = new System.Drawing.Point(272, 146);
            this.rdoNothing.Name = "rdoNothing";
            this.rdoNothing.Size = new System.Drawing.Size(94, 28);
            this.rdoNothing.TabIndex = 5;
            this.rdoNothing.TabStop = true;
            this.rdoNothing.Text = "Nothing";
            this.rdoNothing.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(174, 146);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(92, 28);
            this.rdoFemale.TabIndex = 4;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(99, 146);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(69, 28);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // chbHasOwner
            // 
            this.chbHasOwner.AutoSize = true;
            this.chbHasOwner.Location = new System.Drawing.Point(99, 97);
            this.chbHasOwner.Name = "chbHasOwner";
            this.chbHasOwner.Size = new System.Drawing.Size(134, 28);
            this.chbHasOwner.TabIndex = 2;
            this.chbHasOwner.Text = "Has Owner?";
            this.chbHasOwner.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Date of Birth";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label12.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Favourite";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Weight";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 29);
            this.txtName.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstTakers);
            this.tabPage4.Controls.Add(this.btnTakerAdd);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtLastName);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtTakerName);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage4.Size = new System.Drawing.Size(816, 465);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Care Taker";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstTakers
            // 
            this.lstTakers.FormattingEnabled = true;
            this.lstTakers.ItemHeight = 24;
            this.lstTakers.Location = new System.Drawing.Point(473, 49);
            this.lstTakers.Name = "lstTakers";
            this.lstTakers.Size = new System.Drawing.Size(296, 292);
            this.lstTakers.TabIndex = 5;
            // 
            // btnTakerAdd
            // 
            this.btnTakerAdd.Location = new System.Drawing.Point(237, 177);
            this.btnTakerAdd.Name = "btnTakerAdd";
            this.btnTakerAdd.Size = new System.Drawing.Size(111, 64);
            this.btnTakerAdd.TabIndex = 4;
            this.btnTakerAdd.Text = "Add";
            this.btnTakerAdd.UseVisualStyleBackColor = true;
            this.btnTakerAdd.Click += new System.EventHandler(this.btnTakerAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(159, 118);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(189, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // txtTakerName
            // 
            this.txtTakerName.Location = new System.Drawing.Point(159, 49);
            this.txtTakerName.Name = "txtTakerName";
            this.txtTakerName.Size = new System.Drawing.Size(189, 29);
            this.txtTakerName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuCalorie)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuWeight)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nmuCalorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSop;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ListBox lstFoods;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.ListBox lstPets;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.NumericUpDown nmuWeight;
        private System.Windows.Forms.RadioButton rdoNothing;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.CheckBox chbHasOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbFavourite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ListBox lstTakers;
        private System.Windows.Forms.Button btnTakerAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTakerName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label12;
    }
}

