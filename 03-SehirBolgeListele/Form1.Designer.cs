namespace _03_SehirBolgeListele
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
            {
                con.Dispose();
            }
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
            this.cmbBolgeler = new System.Windows.Forms.ComboBox();
            this.lstSehirler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbBolgeler
            // 
            this.cmbBolgeler.DisplayMember = "BolgeAd";
            this.cmbBolgeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolgeler.FormattingEnabled = true;
            this.cmbBolgeler.Location = new System.Drawing.Point(15, 15);
            this.cmbBolgeler.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBolgeler.Name = "cmbBolgeler";
            this.cmbBolgeler.Size = new System.Drawing.Size(523, 33);
            this.cmbBolgeler.TabIndex = 0;
            this.cmbBolgeler.SelectedIndexChanged += new System.EventHandler(this.cmbBolgeler_SelectedIndexChanged);
            // 
            // lstSehirler
            // 
            this.lstSehirler.FormattingEnabled = true;
            this.lstSehirler.ItemHeight = 25;
            this.lstSehirler.Location = new System.Drawing.Point(15, 84);
            this.lstSehirler.Name = "lstSehirler";
            this.lstSehirler.Size = new System.Drawing.Size(526, 329);
            this.lstSehirler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 449);
            this.Controls.Add(this.lstSehirler);
            this.Controls.Add(this.cmbBolgeler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBolgeler;
        private System.Windows.Forms.ListBox lstSehirler;
    }
}

