namespace WindowsFormsApp1
{
    partial class Form01
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
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.btnOpenForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(12, 12);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenForm2.TabIndex = 0;
            this.btnOpenForm2.Text = "Open Form2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // btnOpenForm3
            // 
            this.btnOpenForm3.Location = new System.Drawing.Point(141, 12);
            this.btnOpenForm3.Name = "btnOpenForm3";
            this.btnOpenForm3.Size = new System.Drawing.Size(75, 23);
            this.btnOpenForm3.TabIndex = 1;
            this.btnOpenForm3.Text = "Open Form3";
            this.btnOpenForm3.UseVisualStyleBackColor = true;
            this.btnOpenForm3.Click += new System.EventHandler(this.btnOpenForm3_Click);
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 50);
            this.Controls.Add(this.btnOpenForm3);
            this.Controls.Add(this.btnOpenForm2);
            this.Name = "Form01";
            this.Text = "Form01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form01_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.Button btnOpenForm3;
    }
}