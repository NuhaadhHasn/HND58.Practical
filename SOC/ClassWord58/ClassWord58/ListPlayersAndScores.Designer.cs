using System.ComponentModel;

namespace ClassWord58
{
    partial class ListPlayersAndScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtBoxScore = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(24, 23);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(147, 24);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name : ";
            // 
            // txtBoxPlayerName
            // 
            this.txtBoxPlayerName.Location = new System.Drawing.Point(177, 27);
            this.txtBoxPlayerName.Name = "txtBoxPlayerName";
            this.txtBoxPlayerName.Size = new System.Drawing.Size(153, 20);
            this.txtBoxPlayerName.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(24, 58);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 24);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score : ";
            // 
            // txtBoxScore
            // 
            this.txtBoxScore.Location = new System.Drawing.Point(177, 62);
            this.txtBoxScore.Name = "txtBoxScore";
            this.txtBoxScore.Size = new System.Drawing.Size(153, 20);
            this.txtBoxScore.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(88, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(177, 104);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 31);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(266, 104);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // ListPlayersAndScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 147);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxScore);
            this.Controls.Add(this.txtBoxPlayerName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "ListPlayersAndScores";
            this.Text = "ListPlayersAndScores";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Button btnPrint;

        private System.Windows.Forms.TextBox txtBoxPlayerName;
        private System.Windows.Forms.Label lblScore;

        private System.Windows.Forms.TextBox txtBoxScore;

        private System.Windows.Forms.Label lblPlayerName;

        #endregion
    }
}