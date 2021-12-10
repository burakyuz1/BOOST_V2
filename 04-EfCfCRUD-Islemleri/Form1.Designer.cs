namespace _04_EfCfCRUD_Islemleri
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
            if (disposing)
                db.Dispose();
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
            this.lstEntries = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtContent = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lstEntries
            // 
            this.lstEntries.FormattingEnabled = true;
            this.lstEntries.ItemHeight = 24;
            this.lstEntries.Items.AddRange(new object[] {
            "Yazilar",
            "Yazılar"});
            this.lstEntries.Location = new System.Drawing.Point(24, 101);
            this.lstEntries.Name = "lstEntries";
            this.lstEntries.Size = new System.Drawing.Size(220, 364);
            this.lstEntries.TabIndex = 3;
            this.lstEntries.SelectedIndexChanged += new System.EventHandler(this.lstEntries_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ENTRIES";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(246, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "TITLE";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(246, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "CONTENT";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(511, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(250, 101);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PromptText = "Your Title";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(533, 23);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMark = "Your Title";
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContent
            // 
            // 
            // 
            // 
            this.txtContent.CustomButton.Image = null;
            this.txtContent.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtContent.CustomButton.Name = "";
            this.txtContent.CustomButton.Size = new System.Drawing.Size(301, 301);
            this.txtContent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContent.CustomButton.TabIndex = 1;
            this.txtContent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContent.CustomButton.UseSelectable = true;
            this.txtContent.CustomButton.Visible = false;
            this.txtContent.Lines = new string[0];
            this.txtContent.Location = new System.Drawing.Point(250, 162);
            this.txtContent.MaxLength = 32767;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PromptText = "Your Content";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.SelectedText = "";
            this.txtContent.SelectionLength = 0;
            this.txtContent.SelectionStart = 0;
            this.txtContent.ShortcutsEnabled = true;
            this.txtContent.Size = new System.Drawing.Size(533, 303);
            this.txtContent.TabIndex = 5;
            this.txtContent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContent.UseSelectable = true;
            this.txtContent.WaterMark = "Your Content";
            this.txtContent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(653, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.Location = new System.Drawing.Point(210, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.Location = new System.Drawing.Point(570, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 46);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(250, 483);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 15);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 540);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lstEntries);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "DAILY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstEntries;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtContent;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroLabel lblTime;
    }
}

