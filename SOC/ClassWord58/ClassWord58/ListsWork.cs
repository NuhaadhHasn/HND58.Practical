using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClassWord58
{
    public partial class ListsWork : Form
    {
        public List<int> numbers = new List<int>();
        
        public ListsWork()
        {
            InitializeComponent();
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            lblListValues.Text = "";
            lblCapacity.Text = "";
            lblNoOfElementsValues.Text = "";
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(9);
            lblCapacity.Text =  numbers.Capacity.ToString();

            foreach (int i in numbers )
            {
                lblListValues.Text += i + ", " ;
            }
            lblNoOfElementsValues.Text = numbers.Count.ToString();
            
            // int[] fewNumbers = { 7, 2, 3, 5 };
            // numbers.AddRange(fewNumbers);
            // lblCapacityArrays.Text = numbers.Capacity.ToString();
            //
            // numbers.Insert(2, 8);
            //
            // lblCapacityInsert.Text = numbers.Capacity.ToString();
            //
            //
            // numbers.Remove(7);
            // numbers.RemoveAll(i => i == 3);
            // numbers.RemoveAt(1);
            // numbers.RemoveRange(1, 3);
            //
            // lblCapacityRemove.Text = numbers.Capacity.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(printList(numbers));
        }

        private string printList(List<int> list)
        {
            string res = "";
            foreach (int item in list)
            {
                res += item + " , ";
            }
            return res;
        }
        
    }
}