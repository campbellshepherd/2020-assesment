using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2020_Game
{
    class Enemy
    {
        public int rotationAngle;
        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enmyRec;
        public Matrix matrixenemy;
        public Point centre;
        public Enemy(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            enemyImage = Properties.Resources.enemy;
            enmyRec = new Rectangle(x, y, width, height);
        }
        public void DrawEnemy(Graphics g)
        {
            enmyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enmyRec);
            centre = new Point(enmyRec.X + width / 2, enmyRec.Y + width / 2);
            matrixenemy = new Matrix();
            matrixenemy.RotateAt(rotationAngle, centre);
            rotationAngle = 0;
            g.Transform = matrixenemy;

        }
        public void MoveEnemy()
        {
            enmyRec.Location = new Point(x, y);

        }
    }
}
