using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWord58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradeFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeFinder gradeFinder = new GradeFinder();
            gradeFinder.MdiParent = this;
            gradeFinder.Show();
        }

        private void vowelCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckVowel checkVowel = new CheckVowel();
            checkVowel.MdiParent = this;
            checkVowel.Show();
        }
    }
}