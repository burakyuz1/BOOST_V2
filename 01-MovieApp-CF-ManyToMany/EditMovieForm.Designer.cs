namespace _01_MovieApp_CF_ManyToMany
{
    partial class EditMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmuRating = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmuYear = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clbGenres = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmuRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rating";
            // 
            // nmuRating
            // 
            this.nmuRating.DecimalPlaces = 1;
            this.nmuRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmuRating.Location = new System.Drawing.Point(95, 105);
            this.nmuRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmuRating.Name = "nmuRating";
            this.nmuRating.Size = new System.Drawing.Size(95, 23);
            this.nmuRating.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(95, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year";
            // 
            // nmuYear
            // 
            this.nmuYear.Location = new System.Drawing.Point(95, 54);
            this.nmuYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nmuYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nmuYear.Name = "nmuYear";
            this.nmuYear.Size = new System.Drawing.Size(95, 23);
            this.nmuYear.TabIndex = 1;
            this.nmuYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(149, 486);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 40);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(230, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clbGenres
            // 
            this.clbGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbGenres.FormattingEnabled = true;
            this.clbGenres.Location = new System.Drawing.Point(26, 167);
            this.clbGenres.Name = "clbGenres";
            this.clbGenres.Size = new System.Drawing.Size(279, 274);
            this.clbGenres.TabIndex = 4;
            // 
            // EditMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 538);
            this.Controls.Add(this.clbGenres);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.nmuYear);
            this.Controls.Add(this.nmuRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditMovieForm";
            this.Text = "Edit Movie";
            ((System.ComponentModel.ISupportInitialize)(this.nmuRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmuRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmuYear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox clbGenres;
    }
}