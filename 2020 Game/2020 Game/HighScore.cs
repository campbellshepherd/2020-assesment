using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_Game
{
    class HighScore
    {
        public HighScore(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public string Name { get; set; }

        public int Score { get; set; }
    }
}
