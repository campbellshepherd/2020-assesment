using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace _2020_Game
{
    public partial class FrmMenu : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";
        List<HighScore> highScores = new List<HighScore>();
        public FrmMenu()
        {
            InitializeComponent();
            var reader = new StreamReader(binPath);
            
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
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DisplayHighScores();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Music);
            simpleSound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmGame form1= new FrmGame(TxtName.Text);
            Hide();
            form1.ShowDialog();
            
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
