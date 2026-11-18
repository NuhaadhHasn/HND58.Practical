using System;
using System.Windows.Forms;

namespace ClassWord58
{
    public partial class GradeFinder : Form
    {
        public GradeFinder()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(txtBoxMarks.Text);
            try
            {
                if (value <= 100)
                {
                    if (value >= 70)
                    {
                        lblGrade.Text = "A";
                    }
                    else if (value >= 60 && value < 70)
                    {
                        lblGrade.Text = "B";
                    }
                    else if (value >= 50 && value < 60)
                    {
                        lblGrade.Text = "C";
                    }
                    else if (value >= 40 && value < 50)
                    {
                        lblGrade.Text = "S";
                    }
                    else
                    {
                        lblGrade.Text = "F";
                    }
                } else
                {
                    MessageBox.Show("Pleas Enter Number between 1-100");
                    lblGrade.Text = "";
                    txtBoxMarks.Clear();
                    txtBoxMarks.Focus();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                txtBoxMarks.Clear();
                txtBoxMarks.Focus();
            }
            

    }

        private void txtBoxMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}