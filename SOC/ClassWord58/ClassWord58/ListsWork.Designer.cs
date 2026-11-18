using System.ComponentModel;

namespace ClassWord58
{
    partial class ListsWork
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
            this.btnAB = new System.Windows.Forms.Button();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblListValues = new System.Windows.Forms.Label();
            this.lblNoOfElementsValues = new System.Windows.Forms.Label();
            this.lblNoOfElements = new System.Windows.Forms.Label();
            this.lblCapacityArrays = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCapacityInsert = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCapacityRemove = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAB
            // 
            this.btnAB.Location = new System.Drawing.Point(30, 27);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(95, 46);
            this.btnAB.TabIndex = 0;
            this.btnAB.Text = "button1";
            this.btnAB.UseVisualStyleBackColor = true;
            this.btnAB.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.Location = new System.Drawing.Point(199, 146);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(163, 32);
            this.lblCapacity.TabIndex = 1;
            this.lblCapacity.Text = "________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capacity : ";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(18, 177);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(129, 24);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "List Values : ";
            // 
            // lblListValues
            // 
            this.lblListValues.Location = new System.Drawing.Point(199, 185);
            this.lblListValues.Name = "lblListValues";
            this.lblListValues.Size = new System.Drawing.Size(163, 24);
            this.lblListValues.TabIndex = 1;
            this.lblListValues.Text = "________________";
            // 
            // lblNoOfElementsValues
            // 
            this.lblNoOfElementsValues.Location = new System.Drawing.Point(199, 224);
            this.lblNoOfElementsValues.Name = "lblNoOfElementsValues";
            this.lblNoOfElementsValues.Size = new System.Drawing.Size(163, 24);
            this.lblNoOfElementsValues.TabIndex = 1;
            this.lblNoOfElementsValues.Text = "________________";
            // 
            // lblNoOfElements
            // 
            this.lblNoOfElements.AutoSize = true;
            this.lblNoOfElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfElements.Location = new System.Drawing.Point(18, 216);
            this.lblNoOfElements.Name = "lblNoOfElements";
            this.lblNoOfElements.Size = new System.Drawing.Size(175, 24);
            this.lblNoOfElements.TabIndex = 1;
            this.lblNoOfElements.Text = "No.Of Elements : ";
            // 
            // lblCapacityArrays
            // 
            this.lblCapacityArrays.Location = new System.Drawing.Point(223, 269);
            this.lblCapacityArrays.Name = "lblCapacityArrays";
            this.lblCapacityArrays.Size = new System.Drawing.Size(119, 28);
            this.lblCapacityArrays.TabIndex = 1;
            this.lblCapacityArrays.Text = "________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Capacity After Array: ";
            // 
            // lblCapacityInsert
            // 
            this.lblCapacityInsert.Location = new System.Drawing.Point(225, 312);
            this.lblCapacityInsert.Name = "lblCapacityInsert";
            this.lblCapacityInsert.Size = new System.Drawing.Size(119, 28);
            this.lblCapacityInsert.TabIndex = 1;
            this.lblCapacityInsert.Text = "________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Capacity After Insert: ";
            // 
            // lblCapacityRemove
            // 
            this.lblCapacityRemove.Location = new System.Drawing.Point(268, 355);
            this.lblCapacityRemove.Name = "lblCapacityRemove";
            this.lblCapacityRemove.Size = new System.Drawing.Size(119, 28);
            this.lblCapacityRemove.TabIndex = 1;
            this.lblCapacityRemove.Text = "________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Capacity After Removing: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListsWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNoOfElements);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoOfElementsValues);
            this.Controls.Add(this.lblListValues);
            this.Controls.Add(this.lblCapacityRemove);
            this.Controls.Add(this.lblCapacityInsert);
            this.Controls.Add(this.lblCapacityArrays);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAB);
            this.Name = "ListsWork";
            this.Text = "ListsWork";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label lblCapacityRemove;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label lblCapacityInsert;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label lblCapacityArrays;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label lblNoOfElements;

        private System.Windows.Forms.Label lblList;

        private System.Windows.Forms.Label lblListValues;
        private System.Windows.Forms.Label lblNoOfElementsValues;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblCapacity;

        private System.Windows.Forms.Button btnAB;

        #endregion
    }
}