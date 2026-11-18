namespace ClassWord58
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vowelCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.systemToolStripMenuItem, this.lab2ToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.systemToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exitToolStripMenuItem });
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lab2ToolStripMenuItem
            // 
            this.lab2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.gradeFinderToolStripMenuItem, this.vowelCheckerToolStripMenuItem });
            this.lab2ToolStripMenuItem.Name = "lab2ToolStripMenuItem";
            this.lab2ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lab2ToolStripMenuItem.Text = "Lab 2";
            // 
            // gradeFinderToolStripMenuItem
            // 
            this.gradeFinderToolStripMenuItem.Name = "gradeFinderToolStripMenuItem";
            this.gradeFinderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.gradeFinderToolStripMenuItem.Text = "Grade Finder";
            this.gradeFinderToolStripMenuItem.Click += new System.EventHandler(this.gradeFinderToolStripMenuItem_Click);
            // 
            // vowelCheckerToolStripMenuItem
            // 
            this.vowelCheckerToolStripMenuItem.Name = "vowelCheckerToolStripMenuItem";
            this.vowelCheckerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.vowelCheckerToolStripMenuItem.Text = "Vowel Checker";
            this.vowelCheckerToolStripMenuItem.Click += new System.EventHandler(this.vowelCheckerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem vowelCheckerToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lab2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeFinderToolStripMenuItem;

        #endregion
    }
}