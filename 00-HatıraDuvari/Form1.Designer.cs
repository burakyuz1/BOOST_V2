namespace _00_HatıraDuvari
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
            this.txtHatıraIcerik = new System.Windows.Forms.TextBox();
            this.btnHatiraEkle = new System.Windows.Forms.Button();
            this.pnlHatiralar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtHatıraIcerik
            // 
            this.txtHatıraIcerik.Location = new System.Drawing.Point(15, 11);
            this.txtHatıraIcerik.Margin = new System.Windows.Forms.Padding(6);
            this.txtHatıraIcerik.Multiline = true;
            this.txtHatıraIcerik.Name = "txtHatıraIcerik";
            this.txtHatıraIcerik.Size = new System.Drawing.Size(284, 295);
            this.txtHatıraIcerik.TabIndex = 0;
            // 
            // btnHatiraEkle
            // 
            this.btnHatiraEkle.Location = new System.Drawing.Point(15, 324);
            this.btnHatiraEkle.Name = "btnHatiraEkle";
            this.btnHatiraEkle.Size = new System.Drawing.Size(111, 32);
            this.btnHatiraEkle.TabIndex = 3;
            this.btnHatiraEkle.Text = "Hatıra Ekle";
            this.btnHatiraEkle.UseVisualStyleBackColor = true;
            this.btnHatiraEkle.Click += new System.EventHandler(this.btnHatiraEkle_Click);
            // 
            // pnlHatiralar
            // 
            this.pnlHatiralar.AutoScroll = true;
            this.pnlHatiralar.Location = new System.Drawing.Point(375, 13);
            this.pnlHatiralar.Name = "pnlHatiralar";
            this.pnlHatiralar.Size = new System.Drawing.Size(481, 343);
            this.pnlHatiralar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 384);
            this.Controls.Add(this.pnlHatiralar);
            this.Controls.Add(this.btnHatiraEkle);
            this.Controls.Add(this.txtHatıraIcerik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHatıraIcerik;
        private System.Windows.Forms.Button btnHatiraEkle;
        private System.Windows.Forms.Panel pnlHatiralar;
    }
}

