using System;
using System.Windows.Forms;

namespace ClassWord58
{
    public partial class CheckVowel : Form
    {
        public CheckVowel()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtBoxName.Text;
                name = name.Substring(0, 1);
                name = name.ToLower();
                lblIsVowel.Text = name;
                switch (name)
                {
                    case "a" : 
                        lblIsVowel.Text = name + " is a Vowel"; 
                        break;
                    case "e" : 
                        lblIsVowel.Text = name + " is a Vowel"; 
                        break;
                    case "i" : 
                        lblIsVowel.Text = name + " is a Vowel"; 
                        break;
                    case "o" : 
                        lblIsVowel.Text = name + " is a Vowel"; 
                        break;
                    case "u" : 
                        lblIsVowel.Text = name + " is a Vowel"; 
                        break;
                    default: 
                        lblIsVowel.Text = name + " is not a Vowel";
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }
    }
}