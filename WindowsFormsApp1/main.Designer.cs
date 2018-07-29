namespace WindowsFormsApp1
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form01ToolStripMenuItem,
            this.form02ToolStripMenuItem,
            this.form03ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form01ToolStripMenuItem
            // 
            this.form01ToolStripMenuItem.Name = "form01ToolStripMenuItem";
            this.form01ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.form01ToolStripMenuItem.Text = "Form01";
            this.form01ToolStripMenuItem.Click += new System.EventHandler(this.form01ToolStripMenuItem_Click);
            // 
            // form02ToolStripMenuItem
            // 
            this.form02ToolStripMenuItem.Name = "form02ToolStripMenuItem";
            this.form02ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.form02ToolStripMenuItem.Text = "Form02";
            this.form02ToolStripMenuItem.Click += new System.EventHandler(this.form02ToolStripMenuItem_Click);
            // 
            // form03ToolStripMenuItem
            // 
            this.form03ToolStripMenuItem.Name = "form03ToolStripMenuItem";
            this.form03ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.form03ToolStripMenuItem.Text = "Form03";
            this.form03ToolStripMenuItem.Click += new System.EventHandler(this.form03ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form03ToolStripMenuItem;
    }
}