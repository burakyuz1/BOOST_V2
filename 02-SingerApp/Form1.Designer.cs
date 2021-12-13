namespace _02_SingerApp
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelSinger = new System.Windows.Forms.Button();
            this.btnUpdateSinger = new System.Windows.Forms.Button();
            this.btnRemoveSinger = new System.Windows.Forms.Button();
            this.btnAddSinger = new System.Windows.Forms.Button();
            this.lstSingers = new System.Windows.Forms.ListBox();
            this.cmbSingerAddNations = new System.Windows.Forms.ComboBox();
            this.txtSingerAddName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNationAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNationUpdate = new System.Windows.Forms.Button();
            this.btnNationRemove = new System.Windows.Forms.Button();
            this.lstNationsAdd = new System.Windows.Forms.ListBox();
            this.txtNationAddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(464, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Singer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelSinger);
            this.groupBox1.Controls.Add(this.btnUpdateSinger);
            this.groupBox1.Controls.Add(this.btnRemoveSinger);
            this.groupBox1.Controls.Add(this.btnAddSinger);
            this.groupBox1.Controls.Add(this.lstSingers);
            this.groupBox1.Controls.Add(this.cmbSingerAddNations);
            this.groupBox1.Controls.Add(this.txtSingerAddName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 568);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Singer";
            // 
            // btnCancelSinger
            // 
            this.btnCancelSinger.Location = new System.Drawing.Point(73, 507);
            this.btnCancelSinger.Name = "btnCancelSinger";
            this.btnCancelSinger.Size = new System.Drawing.Size(105, 32);
            this.btnCancelSinger.TabIndex = 4;
            this.btnCancelSinger.Text = "Cancel";
            this.btnCancelSinger.UseVisualStyleBackColor = true;
            this.btnCancelSinger.Visible = false;
            this.btnCancelSinger.Click += new System.EventHandler(this.btnCancelSinger_Click);
            // 
            // btnUpdateSinger
            // 
            this.btnUpdateSinger.Location = new System.Drawing.Point(186, 507);
            this.btnUpdateSinger.Name = "btnUpdateSinger";
            this.btnUpdateSinger.Size = new System.Drawing.Size(105, 32);
            this.btnUpdateSinger.TabIndex = 4;
            this.btnUpdateSinger.Text = "Update";
            this.btnUpdateSinger.UseVisualStyleBackColor = true;
            this.btnUpdateSinger.Click += new System.EventHandler(this.btnUpdateSinger_Click);
            // 
            // btnRemoveSinger
            // 
            this.btnRemoveSinger.Location = new System.Drawing.Point(297, 507);
            this.btnRemoveSinger.Name = "btnRemoveSinger";
            this.btnRemoveSinger.Size = new System.Drawing.Size(105, 32);
            this.btnRemoveSinger.TabIndex = 4;
            this.btnRemoveSinger.Text = "Remove";
            this.btnRemoveSinger.UseVisualStyleBackColor = true;
            this.btnRemoveSinger.Click += new System.EventHandler(this.btnRemoveSinger_Click);
            // 
            // btnAddSinger
            // 
            this.btnAddSinger.Location = new System.Drawing.Point(297, 172);
            this.btnAddSinger.Name = "btnAddSinger";
            this.btnAddSinger.Size = new System.Drawing.Size(105, 32);
            this.btnAddSinger.TabIndex = 4;
            this.btnAddSinger.Text = "Add";
            this.btnAddSinger.UseVisualStyleBackColor = true;
            this.btnAddSinger.Click += new System.EventHandler(this.btnAddSinger_Click);
            // 
            // lstSingers
            // 
            this.lstSingers.DisplayMember = "SingerName";
            this.lstSingers.FormattingEnabled = true;
            this.lstSingers.ItemHeight = 24;
            this.lstSingers.Location = new System.Drawing.Point(73, 224);
            this.lstSingers.Name = "lstSingers";
            this.lstSingers.Size = new System.Drawing.Size(329, 268);
            this.lstSingers.TabIndex = 3;
            // 
            // cmbSingerAddNations
            // 
            this.cmbSingerAddNations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSingerAddNations.FormattingEnabled = true;
            this.cmbSingerAddNations.Location = new System.Drawing.Point(73, 122);
            this.cmbSingerAddNations.Name = "cmbSingerAddNations";
            this.cmbSingerAddNations.Size = new System.Drawing.Size(329, 32);
            this.cmbSingerAddNations.TabIndex = 2;
            this.cmbSingerAddNations.SelectedIndexChanged += new System.EventHandler(this.cmbSingerAddNations_SelectedIndexChanged);
            // 
            // txtSingerAddName
            // 
            this.txtSingerAddName.Location = new System.Drawing.Point(73, 67);
            this.txtSingerAddName.Name = "txtSingerAddName";
            this.txtSingerAddName.Size = new System.Drawing.Size(329, 29);
            this.txtSingerAddName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Singers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(464, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNationAdd);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnNationUpdate);
            this.groupBox2.Controls.Add(this.btnNationRemove);
            this.groupBox2.Controls.Add(this.lstNationsAdd);
            this.groupBox2.Controls.Add(this.txtNationAddName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 467);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Nation";
            // 
            // btnNationAdd
            // 
            this.btnNationAdd.Location = new System.Drawing.Point(288, 67);
            this.btnNationAdd.Name = "btnNationAdd";
            this.btnNationAdd.Size = new System.Drawing.Size(114, 30);
            this.btnNationAdd.TabIndex = 3;
            this.btnNationAdd.Text = "Add";
            this.btnNationAdd.UseVisualStyleBackColor = true;
            this.btnNationAdd.Click += new System.EventHandler(this.btnNationAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNationUpdate
            // 
            this.btnNationUpdate.Location = new System.Drawing.Point(208, 400);
            this.btnNationUpdate.Name = "btnNationUpdate";
            this.btnNationUpdate.Size = new System.Drawing.Size(94, 42);
            this.btnNationUpdate.TabIndex = 3;
            this.btnNationUpdate.Text = "Update";
            this.btnNationUpdate.UseVisualStyleBackColor = true;
            this.btnNationUpdate.Click += new System.EventHandler(this.btnNationUpdate_Click);
            // 
            // btnNationRemove
            // 
            this.btnNationRemove.Location = new System.Drawing.Point(308, 400);
            this.btnNationRemove.Name = "btnNationRemove";
            this.btnNationRemove.Size = new System.Drawing.Size(94, 42);
            this.btnNationRemove.TabIndex = 3;
            this.btnNationRemove.Text = "Remove";
            this.btnNationRemove.UseVisualStyleBackColor = true;
            this.btnNationRemove.Click += new System.EventHandler(this.btnNationRemove_Click);
            // 
            // lstNationsAdd
            // 
            this.lstNationsAdd.FormattingEnabled = true;
            this.lstNationsAdd.ItemHeight = 24;
            this.lstNationsAdd.Location = new System.Drawing.Point(73, 125);
            this.lstNationsAdd.Name = "lstNationsAdd";
            this.lstNationsAdd.Size = new System.Drawing.Size(329, 268);
            this.lstNationsAdd.TabIndex = 2;
            // 
            // txtNationAddName
            // 
            this.txtNationAddName.Location = new System.Drawing.Point(73, 67);
            this.txtNationAddName.Name = "txtNationAddName";
            this.txtNationAddName.Size = new System.Drawing.Size(194, 29);
            this.txtNationAddName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 638);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "SINGER APP";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSingerAddNations;
        private System.Windows.Forms.TextBox txtSingerAddName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddSinger;
        private System.Windows.Forms.ListBox lstSingers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNationAdd;
        private System.Windows.Forms.Button btnNationUpdate;
        private System.Windows.Forms.Button btnNationRemove;
        private System.Windows.Forms.ListBox lstNationsAdd;
        private System.Windows.Forms.TextBox txtNationAddName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelSinger;
        private System.Windows.Forms.Button btnUpdateSinger;
        private System.Windows.Forms.Button btnRemoveSinger;
    }
}

