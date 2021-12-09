namespace _02_HayvanlarGrup
{
    partial class FormUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbSahibiVarMi = new System.Windows.Forms.CheckBox();
            this.nmuKutle = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoBelirsiz = new System.Windows.Forms.RadioButton();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.rdoDisi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKutle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.txtTur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chbSahibiVarMi);
            this.groupBox1.Controls.Add(this.nmuKutle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.dtpDogumTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdoBelirsiz);
            this.groupBox1.Controls.Add(this.rdoErkek);
            this.groupBox1.Controls.Add(this.rdoDisi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 323);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hayvan Guncelle";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(159, 182);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(229, 30);
            this.txtTur.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tür";
            // 
            // chbSahibiVarMi
            // 
            this.chbSahibiVarMi.AutoSize = true;
            this.chbSahibiVarMi.Location = new System.Drawing.Point(243, 218);
            this.chbSahibiVarMi.Name = "chbSahibiVarMi";
            this.chbSahibiVarMi.Size = new System.Drawing.Size(158, 29);
            this.chbSahibiVarMi.TabIndex = 20;
            this.chbSahibiVarMi.Text = "Sahibi Var mı?";
            this.chbSahibiVarMi.UseVisualStyleBackColor = true;
            // 
            // nmuKutle
            // 
            this.nmuKutle.DecimalPlaces = 2;
            this.nmuKutle.Location = new System.Drawing.Point(159, 219);
            this.nmuKutle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmuKutle.Name = "nmuKutle";
            this.nmuKutle.Size = new System.Drawing.Size(58, 30);
            this.nmuKutle.TabIndex = 19;
            this.nmuKutle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(274, 257);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 36);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(159, 142);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(229, 30);
            this.dtpDogumTarihi.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kütle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Doğum Tarihi";
            // 
            // rdoBelirsiz
            // 
            this.rdoBelirsiz.AutoSize = true;
            this.rdoBelirsiz.Location = new System.Drawing.Point(303, 92);
            this.rdoBelirsiz.Name = "rdoBelirsiz";
            this.rdoBelirsiz.Size = new System.Drawing.Size(92, 29);
            this.rdoBelirsiz.TabIndex = 15;
            this.rdoBelirsiz.TabStop = true;
            this.rdoBelirsiz.Text = "Belirsiz";
            this.rdoBelirsiz.UseVisualStyleBackColor = true;
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Location = new System.Drawing.Point(223, 92);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(80, 29);
            this.rdoErkek.TabIndex = 14;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = true;
            // 
            // rdoDisi
            // 
            this.rdoDisi.AutoSize = true;
            this.rdoDisi.Location = new System.Drawing.Point(159, 92);
            this.rdoDisi.Name = "rdoDisi";
            this.rdoDisi.Size = new System.Drawing.Size(62, 29);
            this.rdoDisi.TabIndex = 13;
            this.rdoDisi.TabStop = true;
            this.rdoDisi.Text = "Disi";
            this.rdoDisi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cinsiyet";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(159, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(229, 30);
            this.txtAd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ad";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(154, 257);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(114, 36);
            this.btnIptal.TabIndex = 23;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 323);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUpdate";
            this.Text = "UPDATE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKutle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbSahibiVarMi;
        private System.Windows.Forms.NumericUpDown nmuKutle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoBelirsiz;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.RadioButton rdoDisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIptal;
    }
}