namespace StringComparison
{
    partial class frmStringComparison
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblStrings = new System.Windows.Forms.Label();
            this.lblCompare = new System.Windows.Forms.Label();
            this.txtFirstString = new System.Windows.Forms.TextBox();
            this.txtSecondString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(95, 212);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(89, 37);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblStrings
            // 
            this.lblStrings.AutoSize = true;
            this.lblStrings.Location = new System.Drawing.Point(13, 35);
            this.lblStrings.Name = "lblStrings";
            this.lblStrings.Size = new System.Drawing.Size(110, 13);
            this.lblStrings.TabIndex = 1;
            this.lblStrings.Text = "Enter the strings here:";
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(12, 113);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(123, 13);
            this.lblCompare.TabIndex = 2;
            this.lblCompare.Text = "Are the strings the same:";
            // 
            // txtFirstString
            // 
            this.txtFirstString.Location = new System.Drawing.Point(172, 28);
            this.txtFirstString.Name = "txtFirstString";
            this.txtFirstString.Size = new System.Drawing.Size(100, 20);
            this.txtFirstString.TabIndex = 3;
            // 
            // txtSecondString
            // 
            this.txtSecondString.Location = new System.Drawing.Point(172, 54);
            this.txtSecondString.Name = "txtSecondString";
            this.txtSecondString.Size = new System.Drawing.Size(100, 20);
            this.txtSecondString.TabIndex = 4;
            // 
            // frmStringComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtSecondString);
            this.Controls.Add(this.txtFirstString);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.lblStrings);
            this.Controls.Add(this.btnCompare);
            this.Name = "frmStringComparison";
            this.Text = "String Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblStrings;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.TextBox txtFirstString;
        private System.Windows.Forms.TextBox txtSecondString;
    }
}

