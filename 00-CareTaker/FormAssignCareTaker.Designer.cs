namespace _00_CareTaker
{
    partial class FormAssignCareTaker
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
            this.lstCareTakers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCareTakers
            // 
            this.lstCareTakers.FormattingEnabled = true;
            this.lstCareTakers.Location = new System.Drawing.Point(29, 37);
            this.lstCareTakers.Name = "lstCareTakers";
            this.lstCareTakers.Size = new System.Drawing.Size(244, 238);
            this.lstCareTakers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Care Takers";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(294, 37);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(117, 23);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // FormAssignCareTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 333);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCareTakers);
            this.Name = "FormAssignCareTaker";
            this.Text = "FormAssignCareTaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCareTakers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssign;
    }
}