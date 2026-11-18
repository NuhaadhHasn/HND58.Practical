using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWork5840
{
    public partial class Form1 : Form
    {
        int number1, number2, result, noOfCounts=0;
        String Q4Value;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConver_Click_1(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtBoxCm.Text);
            double result = value / 100;
            lblResult.Text = result.ToString() + "Meter";
        }

        private void btn2A_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32('A');
            MessageBox.Show(a.ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn2B_Click(object sender, EventArgs e)
        {
            int s=890; 
            double a=s;   
            MessageBox.Show(a.ToString());
        }

        private void btn2C_Click(object sender, EventArgs e)
        {
            double a=890.08;    
            MessageBox.Show(a.ToString());
        }

        private void btn2D_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32("A");    
            MessageBox.Show(a.ToString()); 
        }

        private void btn2E_Click(object sender, EventArgs e)
        {
            String a=800.ToString();  
            MessageBox.Show(a); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.noOfCounts += 1;
            number1 = Convert.ToInt32(txtBoxNo1.Text);
            number2 = Convert.ToInt32(txtBoxNo2.Text);
            result = number1 + number2;
            txtBoxResult.Text = result.ToString();
            lblCalcCount.Text = noOfCounts.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            this.noOfCounts += 1;
            number1 = Convert.ToInt32(txtBoxNo1.Text);
            number2 = Convert.ToInt32(txtBoxNo2.Text);
            result = number1 - number2;
            txtBoxResult.Text = result.ToString();
            lblCalcCount.Text = noOfCounts.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            this.noOfCounts += 1;
            number1 = Convert.ToInt32(txtBoxNo1.Text);
            number2 = Convert.ToInt32(txtBoxNo2.Text);
            result = number1 * number2;
            txtBoxResult.Text = result.ToString();
            lblCalcCount.Text = noOfCounts.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            this.noOfCounts += 1;
            number1 = Convert.ToInt32(txtBoxNo1.Text);
            number2 = Convert.ToInt32(txtBoxNo2.Text);
            result = number1 / number2;
            txtBoxResult.Text = result.ToString();
            lblCalcCount.Text = noOfCounts.ToString();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            this.noOfCounts += 1;
            number1 = Convert.ToInt32(txtBoxNo1.Text);
            number2 = Convert.ToInt32(txtBoxNo2.Text);
            result = number1 % number2;
            txtBoxResult.Text = result.ToString();
            lblCalcCount.Text = noOfCounts.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxNo2.Clear();
            txtBoxNo1.Clear();
            txtBoxResult.Clear();
            txtBoxCm.Clear();
            lblCalcCount.Text = "0";
            lblResult.Text = "";
        }

        private void btn4A_Click(object sender, EventArgs e)
        {
            Q4Value = lblStringValue.Text;
            Q4Value = Q4Value.Substring(19, 20);
            lblStringValue2.Text = Q4Value.ToString();
        }

        private void btn4B_Click(object sender, EventArgs e)
        {
            Q4Value = lblStringValue.Text;
            Q4Value = Q4Value.Substring(3, 15);
            lblStringValue2.Text = Q4Value.ToString();
        }

        private void btn4C_Click(object sender, EventArgs e)
        {
            Q4Value = lblStringValue.Text;
            Q4Value = Q4Value.ToUpper();
            lblStringValue2.Text = Q4Value.ToString();
        }

        private void btn4D_Click(object sender, EventArgs e)
        {
            Q4Value = lblStringValue.Text;
            Q4Value = Q4Value.Substring(9, 9);
            Q4Value = Q4Value.ToUpper();
            lblStringValue2.Text = Q4Value.ToString();
        }

        private void btn4E_Click(object sender, EventArgs e)
        {
            Q4Value = lblStringValue.Text;
            Q4Value = Q4Value.IndexOf("q").ToString();
            lblStringValue2.Text = Q4Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string qa1 = Q1.Text, qa2 = Q2.Text, qa3 = Q3.Text;
            string amount = qa1.ToString();

        }
    }
}