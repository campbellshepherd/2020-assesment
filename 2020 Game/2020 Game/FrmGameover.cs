using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2020_Game
{
    public partial class FrmGameover : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";
        List<HighScore> highScores = new List<HighScore>();
        public FrmGameover(string playerscore, string playername)
        {
            
            
            InitializeComponent();
            lblScore.Text = playerscore;
            lblName.Text = playername;
            var reader = new StreamReader(binPath);
            Cursor.Show();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');
                highScores.Add(new HighScore(values[0], Int32.Parse(values[1])));
            }
            reader.Close();
        }
        public void DisplayHighScores()
        {
            foreach (HighScore s in highScores)
            {
                lstBoxName.Items.Add(s.Name);
                lstBoxScore.Items.Add(s.Score);

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FrmGame form1 = new FrmGame(TxtName.Text);
            Hide();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmGameover_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(lblScore.Text) > lowest_score)
            {
               
                highScores.Add(new HighScore(lblName.Text, int.Parse(lblScore.Text)));
            }
            else
            {
                lblMessage.Text = "Keep trying to make the top ten!";
            }
            SortHighScores();
            DisplayHighScores();
            SaveHighScores();
        }
        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }
        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScore score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
