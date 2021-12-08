namespace _02_HayvanlarGrup
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
                con.Close();
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
            this.grpHayvanlar = new System.Windows.Forms.GroupBox();
            this.dgvHayvanlar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SahibiVarMi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kutle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKutle)).BeginInit();
            this.grpHayvanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 311);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hayvan Ekle";
            // 
            // chbSahibiVarMi
            // 
            this.chbSahibiVarMi.AutoSize = true;
            this.chbSahibiVarMi.Location = new System.Drawing.Point(243, 200);
            this.chbSahibiVarMi.Name = "chbSahibiVarMi";
            this.chbSahibiVarMi.Size = new System.Drawing.Size(145, 26);
            this.chbSahibiVarMi.TabIndex = 20;
            this.chbSahibiVarMi.Text = "Sahibi Var mı?";
            this.chbSahibiVarMi.UseVisualStyleBackColor = true;
            // 
            // nmuKutle
            // 
            this.nmuKutle.DecimalPlaces = 2;
            this.nmuKutle.Location = new System.Drawing.Point(159, 201);
            this.nmuKutle.Name = "nmuKutle";
            this.nmuKutle.Size = new System.Drawing.Size(58, 27);
            this.nmuKutle.TabIndex = 19;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(274, 239);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 36);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(159, 142);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(229, 27);
            this.dtpDogumTarihi.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kütle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Doğum Tarihi";
            // 
            // rdoBelirsiz
            // 
            this.rdoBelirsiz.AutoSize = true;
            this.rdoBelirsiz.Location = new System.Drawing.Point(303, 92);
            this.rdoBelirsiz.Name = "rdoBelirsiz";
            this.rdoBelirsiz.Size = new System.Drawing.Size(85, 26);
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
            this.rdoErkek.Size = new System.Drawing.Size(74, 26);
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
            this.rdoDisi.Size = new System.Drawing.Size(58, 26);
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
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cinsiyet";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(159, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(229, 27);
            this.txtAd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ad";
            // 
            // grpHayvanlar
            // 
            this.grpHayvanlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHayvanlar.Controls.Add(this.dgvHayvanlar);
            this.grpHayvanlar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpHayvanlar.Location = new System.Drawing.Point(426, 12);
            this.grpHayvanlar.Name = "grpHayvanlar";
            this.grpHayvanlar.Size = new System.Drawing.Size(658, 317);
            this.grpHayvanlar.TabIndex = 11;
            this.grpHayvanlar.TabStop = false;
            this.grpHayvanlar.Text = "Hayvan Sayısı:";
            // 
            // dgvHayvanlar
            // 
            this.dgvHayvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHayvanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad,
            this.Cinsiyet,
            this.SahibiVarMi,
            this.DogumTarihi,
            this.Kutle,
            this.Tur});
            this.dgvHayvanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHayvanlar.Location = new System.Drawing.Point(3, 23);
            this.dgvHayvanlar.MultiSelect = false;
            this.dgvHayvanlar.Name = "dgvHayvanlar";
            this.dgvHayvanlar.RowHeadersVisible = false;
            this.dgvHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHayvanlar.Size = new System.Drawing.Size(652, 291);
            this.dgvHayvanlar.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(794, 336);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(164, 45);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSil.Location = new System.Drawing.Point(964, 336);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 45);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Ad
            // 
            this.Ad.HeaderText = "AD";
            this.Ad.Name = "Ad";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "CINSIYET";
            this.Cinsiyet.Name = "Cinsiyet";
            // 
            // SahibiVarMi
            // 
            this.SahibiVarMi.HeaderText = "SAHİP DURUMU";
            this.SahibiVarMi.Name = "SahibiVarMi";
            this.SahibiVarMi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SahibiVarMi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.HeaderText = "DOĞUM TARİHİ";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // Kutle
            // 
            this.Kutle.HeaderText = "KÜTLE";
            this.Kutle.Name = "Kutle";
            // 
            // Tur
            // 
            this.Tur.HeaderText = "TÜR";
            this.Tur.Name = "Tur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1085, 401);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.grpHayvanlar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "HAYVANLAR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKutle)).EndInit();
            this.grpHayvanlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox grpHayvanlar;
        private System.Windows.Forms.DataGridView dgvHayvanlar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SahibiVarMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kutle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
    }
}

