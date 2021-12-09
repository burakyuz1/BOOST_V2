namespace _00_YapilacaklarListesi
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
            this.dgvYapilacaklar = new System.Windows.Forms.DataGridView();
            this.btnCheckState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYapilacaklar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYapilacaklar
            // 
            this.dgvYapilacaklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYapilacaklar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYapilacaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYapilacaklar.Location = new System.Drawing.Point(23, 159);
            this.dgvYapilacaklar.MultiSelect = false;
            this.dgvYapilacaklar.Name = "dgvYapilacaklar";
            this.dgvYapilacaklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYapilacaklar.Size = new System.Drawing.Size(765, 247);
            this.dgvYapilacaklar.TabIndex = 0;
            // 
            // btnCheckState
            // 
            this.btnCheckState.Location = new System.Drawing.Point(693, 105);
            this.btnCheckState.Name = "btnCheckState";
            this.btnCheckState.Size = new System.Drawing.Size(75, 23);
            this.btnCheckState.TabIndex = 1;
            this.btnCheckState.Text = "button1";
            this.btnCheckState.UseVisualStyleBackColor = true;
            this.btnCheckState.Click += new System.EventHandler(this.btnCheckState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.btnCheckState);
            this.Controls.Add(this.dgvYapilacaklar);
            this.Name = "Form1";
            this.Text = "YAPILACAKLAR ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYapilacaklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYapilacaklar;
        private System.Windows.Forms.Button btnCheckState;
    }
}

