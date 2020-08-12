using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2020_Game
{
    class Player
    {
        public int rotationAngle;
        public Matrix matrix;
        public Point centre;
        public int x, y, width, height;
        public Rectangle playerRec;
        public Image player;
        public Player()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            rotationAngle = 0;
            player = Properties.Resources.ogre1;
            playerRec= new Rectangle(x, y, width, height);
        }
        public void drawPlayer(Graphics g)
        {
            centre = new Point(playerRec.X + width / 2, playerRec.Y + width / 2);
            matrix = new Matrix();
            matrix.RotateAt(rotationAngle, centre);
            g.Transform = matrix;
            g.DrawImage(player, playerRec);
        }
        public void movePlayer(int mouseX,int mouseY)
        {
            playerRec.X = mouseX - (playerRec.Width / 2);
            playerRec.Y = mouseY - (playerRec.Height / 2);
        }
    }
}
