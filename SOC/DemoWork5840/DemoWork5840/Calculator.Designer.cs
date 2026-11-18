using System.ComponentModel;

namespace DemoWork5840
{
    partial class Calculator
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
            this.lblNo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNo1 = new System.Windows.Forms.TextBox();
            this.txtBoxNo2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnPerc = new System.Windows.Forms.Button();
            this.lblNOCD = new System.Windows.Forms.Label();
            this.lblCalcCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNo1
            // 
            this.lblNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo1.Location = new System.Drawing.Point(18, 13);
            this.lblNo1.Name = "lblNo1";
            this.lblNo1.Size = new System.Drawing.Size(119, 25);
            this.lblNo1.TabIndex = 0;
            this.lblNo1.Text = "Number One : ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Two : ";
            // 
            // txtBoxNo1
            // 
            this.txtBoxNo1.Location = new System.Drawing.Point(143, 15);
            this.txtBoxNo1.Name = "txtBoxNo1";
            this.txtBoxNo1.Size = new System.Drawing.Size(141, 20);
            this.txtBoxNo1.TabIndex = 1;
            // 
            // txtBoxNo2
            // 
            this.txtBoxNo2.Location = new System.Drawing.Point(143, 50);
            this.txtBoxNo2.Name = "txtBoxNo2";
            this.txtBoxNo2.Size = new System.Drawing.Size(141, 20);
            this.txtBoxNo2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(64, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(106, 76);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(36, 35);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(148, 76);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(36, 35);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(190, 76);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(36, 35);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(18, 115);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(119, 25);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result : ";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(143, 117);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(141, 20);
            this.txtBoxResult.TabIndex = 1;
            // 
            // btnPerc
            // 
            this.btnPerc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerc.Location = new System.Drawing.Point(232, 76);
            this.btnPerc.Name = "btnPerc";
            this.btnPerc.Size = new System.Drawing.Size(36, 35);
            this.btnPerc.TabIndex = 2;
            this.btnPerc.Text = "%";
            this.btnPerc.UseVisualStyleBackColor = true;
            // 
            // lblNOCD
            // 
            this.lblNOCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOCD.Location = new System.Drawing.Point(18, 153);
            this.lblNOCD.Name = "lblNOCD";
            this.lblNOCD.Size = new System.Drawing.Size(231, 25);
            this.lblNOCD.TabIndex = 0;
            this.lblNOCD.Text = "Number Of Calculations Done : ";
            // 
            // lblCalcCount
            // 
            this.lblCalcCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcCount.Location = new System.Drawing.Point(255, 153);
            this.lblCalcCount.Name = "lblCalcCount";
            this.lblCalcCount.Size = new System.Drawing.Size(29, 25);
            this.lblCalcCount.TabIndex = 0;
            this.lblCalcCount.Text = "0 ";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerc);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxNo2);
            this.Controls.Add(this.lblNOCD);
            this.Controls.Add(this.lblCalcCount);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBoxNo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNo1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnPerc;
        private System.Windows.Forms.Label lblNOCD;
        private System.Windows.Forms.Label lblCalcCount;
        private System.Windows.Forms.Label lblNo1;

        private System.Windows.Forms.Button btnSub;

        private System.Windows.Forms.TextBox txtBoxNo1;
        private System.Windows.Forms.TextBox txtBoxNo2;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}