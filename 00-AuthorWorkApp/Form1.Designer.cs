namespace _00_AuthorWorkApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstWorks = new System.Windows.Forms.ListBox();
            this.pcbAuthor = new System.Windows.Forms.PictureBox();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpAuthor = new System.Windows.Forms.GroupBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtImageLocation = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstWorkPanel = new System.Windows.Forms.ListBox();
            this.grpAddWork = new System.Windows.Forms.GroupBox();
            this.btnCancelWork = new System.Windows.Forms.Button();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.txtContentWork = new System.Windows.Forms.TextBox();
            this.txtTitleWork = new System.Windows.Forms.TextBox();
            this.cmbWorkAuthors = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAuthor)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpAuthor.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpAddWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1185, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lstWorks);
            this.tabPage1.Controls.Add(this.pcbAuthor);
            this.tabPage1.Controls.Add(this.cmbAuthors);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1177, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(465, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(693, 366);
            this.textBox1.TabIndex = 4;
            // 
            // lstWorks
            // 
            this.lstWorks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWorks.FormattingEnabled = true;
            this.lstWorks.ItemHeight = 24;
            this.lstWorks.Location = new System.Drawing.Point(465, 52);
            this.lstWorks.Name = "lstWorks";
            this.lstWorks.Size = new System.Drawing.Size(693, 148);
            this.lstWorks.TabIndex = 3;
            // 
            // pcbAuthor
            // 
            this.pcbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbAuthor.Location = new System.Drawing.Point(26, 95);
            this.pcbAuthor.Name = "pcbAuthor";
            this.pcbAuthor.Size = new System.Drawing.Size(395, 477);
            this.pcbAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbAuthor.TabIndex = 2;
            this.pcbAuthor.TabStop = false;
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.DisplayMember = "Name";
            this.cmbAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(103, 29);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(318, 32);
            this.cmbAuthors.TabIndex = 1;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.cmbAuthors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Work";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Works";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authors";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstAuthors);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.grpAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstAuthors
            // 
            this.lstAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 24;
            this.lstAuthors.Location = new System.Drawing.Point(13, 341);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(1131, 268);
            this.lstAuthors.TabIndex = 2;
            this.lstAuthors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAuthors_KeyDown);
            this.lstAuthors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAuthors_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Authors";
            // 
            // grpAuthor
            // 
            this.grpAuthor.Controls.Add(this.btnAddAuthor);
            this.grpAuthor.Controls.Add(this.btnCancel);
            this.grpAuthor.Controls.Add(this.txtImageLocation);
            this.grpAuthor.Controls.Add(this.txtAuthorName);
            this.grpAuthor.Controls.Add(this.label5);
            this.grpAuthor.Controls.Add(this.label4);
            this.grpAuthor.Location = new System.Drawing.Point(9, 7);
            this.grpAuthor.Name = "grpAuthor";
            this.grpAuthor.Size = new System.Drawing.Size(533, 284);
            this.grpAuthor.TabIndex = 0;
            this.grpAuthor.TabStop = false;
            this.grpAuthor.Text = "Add Author";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(378, 175);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(105, 37);
            this.btnAddAuthor.TabIndex = 2;
            this.btnAddAuthor.Text = "Add";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.Location = new System.Drawing.Point(220, 115);
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(250, 29);
            this.txtImageLocation.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(220, 56);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(250, 29);
            this.txtAuthorName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Image Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstWorkPanel);
            this.tabPage3.Controls.Add(this.grpAddWork);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1177, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Works";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstWorkPanel
            // 
            this.lstWorkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWorkPanel.FormattingEnabled = true;
            this.lstWorkPanel.ItemHeight = 24;
            this.lstWorkPanel.Location = new System.Drawing.Point(603, 50);
            this.lstWorkPanel.Name = "lstWorkPanel";
            this.lstWorkPanel.Size = new System.Drawing.Size(571, 556);
            this.lstWorkPanel.TabIndex = 0;
            // 
            // grpAddWork
            // 
            this.grpAddWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAddWork.Controls.Add(this.btnCancelWork);
            this.grpAddWork.Controls.Add(this.btnAddWork);
            this.grpAddWork.Controls.Add(this.txtContentWork);
            this.grpAddWork.Controls.Add(this.txtTitleWork);
            this.grpAddWork.Controls.Add(this.cmbWorkAuthors);
            this.grpAddWork.Controls.Add(this.label9);
            this.grpAddWork.Controls.Add(this.label8);
            this.grpAddWork.Controls.Add(this.label7);
            this.grpAddWork.Location = new System.Drawing.Point(6, 6);
            this.grpAddWork.Name = "grpAddWork";
            this.grpAddWork.Size = new System.Drawing.Size(589, 626);
            this.grpAddWork.TabIndex = 0;
            this.grpAddWork.TabStop = false;
            this.grpAddWork.Text = "Add Work";
            // 
            // btnCancelWork
            // 
            this.btnCancelWork.Location = new System.Drawing.Point(383, 561);
            this.btnCancelWork.Name = "btnCancelWork";
            this.btnCancelWork.Size = new System.Drawing.Size(97, 39);
            this.btnCancelWork.TabIndex = 4;
            this.btnCancelWork.Text = "Cancel";
            this.btnCancelWork.UseVisualStyleBackColor = true;
            // 
            // btnAddWork
            // 
            this.btnAddWork.Location = new System.Drawing.Point(486, 561);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(97, 39);
            this.btnAddWork.TabIndex = 4;
            this.btnAddWork.Text = "Add";
            this.btnAddWork.UseVisualStyleBackColor = true;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // txtContentWork
            // 
            this.txtContentWork.Location = new System.Drawing.Point(20, 208);
            this.txtContentWork.Multiline = true;
            this.txtContentWork.Name = "txtContentWork";
            this.txtContentWork.Size = new System.Drawing.Size(563, 346);
            this.txtContentWork.TabIndex = 3;
            // 
            // txtTitleWork
            // 
            this.txtTitleWork.Location = new System.Drawing.Point(97, 44);
            this.txtTitleWork.Name = "txtTitleWork";
            this.txtTitleWork.Size = new System.Drawing.Size(486, 29);
            this.txtTitleWork.TabIndex = 2;
            // 
            // cmbWorkAuthors
            // 
            this.cmbWorkAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkAuthors.FormattingEnabled = true;
            this.cmbWorkAuthors.Location = new System.Drawing.Point(97, 97);
            this.cmbWorkAuthors.Name = "cmbWorkAuthors";
            this.cmbWorkAuthors.Size = new System.Drawing.Size(486, 32);
            this.cmbWorkAuthors.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Content";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Works";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 672);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Author Works";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAuthor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpAuthor.ResumeLayout(false);
            this.grpAuthor.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpAddWork.ResumeLayout(false);
            this.grpAddWork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstWorks;
        private System.Windows.Forms.PictureBox pcbAuthor;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstAuthors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtImageLocation;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstWorkPanel;
        private System.Windows.Forms.GroupBox grpAddWork;
        private System.Windows.Forms.TextBox txtContentWork;
        private System.Windows.Forms.TextBox txtTitleWork;
        private System.Windows.Forms.ComboBox cmbWorkAuthors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelWork;
        private System.Windows.Forms.Button btnAddWork;
    }
}

