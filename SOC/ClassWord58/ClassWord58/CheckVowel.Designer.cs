using System.ComponentModel;

namespace ClassWord58
{
    partial class CheckVowel
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblFirstLetter = new System.Windows.Forms.Label();
            this.lblIsVowel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(102, 11);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(177, 29);
            this.txtBoxName.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(67, 46);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 40);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblFirstLetter
            // 
            this.lblFirstLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLetter.Location = new System.Drawing.Point(15, 95);
            this.lblFirstLetter.Name = "lblFirstLetter";
            this.lblFirstLetter.Size = new System.Drawing.Size(109, 26);
            this.lblFirstLetter.TabIndex = 3;
            this.lblFirstLetter.Text = "First Letter : ";
            // 
            // lblIsVowel
            // 
            this.lblIsVowel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIsVowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsVowel.Location = new System.Drawing.Point(130, 90);
            this.lblIsVowel.Name = "lblIsVowel";
            this.lblIsVowel.Size = new System.Drawing.Size(168, 31);
            this.lblIsVowel.TabIndex = 3;
            // 
            // CheckVowel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 140);
            this.Controls.Add(this.lblIsVowel);
            this.Controls.Add(this.lblFirstLetter);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Name = "CheckVowel";
            this.Text = "CheckVowel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblFirstLetter;
        private System.Windows.Forms.Label lblIsVowel;

        #endregion
    }
}