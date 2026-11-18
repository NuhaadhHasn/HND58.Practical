using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClassWord58
{
    public partial class ListPlayersAndScores : Form
    {
        List<string> Players = new List<string>();
        List<int> Scores= new List<int>();
        string PlayerName;
        int Score;
        
        public ListPlayersAndScores()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PlayerName = txtBoxPlayerName.Text;
            Score = Convert.ToInt32(txtBoxScore.Text);
            
            Players.Add(PlayerName);
            Scores.Add(Score);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string result = "Player\t Name\t\t score\n";
            int count = 1;
            for (int i = 0; i < Scores.Count; i++)
            {
                result += count + ".\t" + Players[i] + "\t" + Scores[i] + "\n";
                count++;
            }

            MessageBox.Show(result);
        }
    }
}