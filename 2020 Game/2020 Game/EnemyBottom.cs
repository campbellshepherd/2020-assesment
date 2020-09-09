using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2020_Game
{
    class EnemyBottom
    {
        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enmyRec;
        public Matrix matrixenemy;
        public Point centreEnemy;
        public EnemyBottom(int spacing)
        {
            x = spacing;
            y = 500;
            width = 35;
            height = 35;
            enemyImage = Properties.Resources.enemy;
            enmyRec = new Rectangle(x, y, width, height);
        }
        public void DrawEnemy(Graphics g)
        {
            enmyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enmyRec);
            centreEnemy = new Point(x,y);
            matrixenemy = new Matrix();
           
            g.Transform = matrixenemy;

        }
        public void MoveEnemy()
        {
            enmyRec.Location = new Point(x, y);

        }
    }
}
