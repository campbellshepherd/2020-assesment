using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace _2020_Game
{
    class Enemy
    {
        public int rotationAngle;
        public int x2, y2, width2, height2;
        public Image enemyImage;
        public Rectangle enmyRec;
        public Matrix matrixenemy;
        public Point centre;
        public Enemy(int spacing)
        {
            x2 = spacing;
            y2 = 10;
            width2 = 20;
            height2 = 20;
            enemyImage = Properties.Resources.enemy;
            enmyRec = new Rectangle(x2, y2, width2, height2);
        }
        public void DrawEnemy(Graphics g)
        {
            enmyRec = new Rectangle(x2, y2, width2, height2);
            g.DrawImage(enemyImage, enmyRec);
            centre = new Point(enmyRec.X + width2 / 2, enmyRec.Y + width2 / 2);
            matrixenemy = new Matrix();
            matrixenemy.RotateAt(rotationAngle, centre);
            g.Transform = matrixenemy;

        }
        public void MoveEnemy()
        {
            enmyRec.Location = new Point(x2, y2);
            
        }
    }
}
