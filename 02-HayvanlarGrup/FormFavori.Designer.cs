namespace _02_HayvanlarGrup
{
    partial class FormFavori
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
            this.lstHayvanlar = new System.Windows.Forms.ListBox();
            this.lblFavoriYiyecek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstHayvanlar
            // 
            this.lstHayvanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstHayvanlar.FormattingEnabled = true;
            this.lstHayvanlar.ItemHeight = 24;
            this.lstHayvanlar.Location = new System.Drawing.Point(40, 167);
            this.lstHayvanlar.Name = "lstHayvanlar";
            this.lstHayvanlar.Size = new System.Drawing.Size(462, 364);
            this.lstHayvanlar.TabIndex = 0;
            // 
            // lblFavoriYiyecek
            // 
            this.lblFavoriYiyecek.AutoSize = true;
            this.lblFavoriYiyecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFavoriYiyecek.ForeColor = System.Drawing.Color.Maroon;
            this.lblFavoriYiyecek.Location = new System.Drawing.Point(34, 82);
            this.lblFavoriYiyecek.Name = "lblFavoriYiyecek";
            this.lblFavoriYiyecek.Size = new System.Drawing.Size(86, 31);
            this.lblFavoriYiyecek.TabIndex = 1;
            this.lblFavoriYiyecek.Text = "label1";
            // 
            // FormFavori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 601);
            this.Controls.Add(this.lblFavoriYiyecek);
            this.Controls.Add(this.lstHayvanlar);
            this.Name = "FormFavori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFavori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHayvanlar;
        private System.Windows.Forms.Label lblFavoriYiyecek;
    }
}