using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2020_Game
{
    class Player
    {
        public int x, y, width, height;
        public Rectangle playerRec;
        public Image player;
        public Player()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            player = Properties.Resources.ogre1;
            playerRec= new Rectangle(x, y, width, height);
        }
        public void drawPlayer(Graphics g)
        {
            g.DrawImage(player, playerRec);
        }
    }
}
