using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2020_Game
{
    class Enemy
    {
        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enmyRec;
        public Enemy(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
        }
    }
}
