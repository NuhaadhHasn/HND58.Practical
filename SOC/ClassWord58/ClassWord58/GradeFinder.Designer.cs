using System.ComponentModel;

namespace ClassWord58
{
    partial class GradeFinder
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
            this.lblSubMark = new System.Windows.Forms.Label();
            this.lblSubGrade = new System.Windows.Forms.Label();
            this.txtBoxMarks = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubMark
            // 
            this.lblSubMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMark.Location = new System.Drawing.Point(12, 23);
            this.lblSubMark.Name = "lblSubMark";
            this.lblSubMark.Size = new System.Drawing.Size(189, 33);
            this.lblSubMark.TabIndex = 0;
            this.lblSubMark.Text = "Enter Subject Mark : ";
            // 
            // lblSubGrade
            // 
            this.lblSubGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGrade.Location = new System.Drawing.Point(371, 20);
            this.lblSubGrade.Name = "lblSubGrade";
            this.lblSubGrade.Size = new System.Drawing.Size(148, 33);
            this.lblSubGrade.TabIndex = 0;
            this.lblSubGrade.Text = "Subject Grade : ";
            // 
            // txtBoxMarks
            // 
            this.txtBoxMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMarks.Location = new System.Drawing.Point(207, 20);
            this.txtBoxMarks.Name = "txtBoxMarks";
            this.txtBoxMarks.Size = new System.Drawing.Size(131, 29);
            this.txtBoxMarks.TabIndex = 1;
            this.txtBoxMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMarks_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(207, 55);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(131, 47);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(405, 53);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(56, 49);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 133);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBoxMarks);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSubGrade);
            this.Controls.Add(this.lblSubMark);
            this.Name = "GradeFinder";
            this.Text = "GradeFinder";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblGrade;

        private System.Windows.Forms.TextBox txtBoxMarks;
        private System.Windows.Forms.Button btnCheck;

        private System.Windows.Forms.Label lblSubMark;
        private System.Windows.Forms.Label lblSubGrade;

        #endregion
    }
}