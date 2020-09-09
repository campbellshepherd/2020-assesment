using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2020_Game
{
    class Bullet
    {
        public int x, y, width, height;
        public int bulletRotated;
        public double xSpeed, ySpeed;
        public Image bullet;
        public Rectangle bulletRec;
        public Matrix matrixBullet;
        Point centreBullet;
        public Bullet(Rectangle playerRec, int bulletRotate)
        {
            width = 15;
            height = 15;
            bullet = Properties.Resources.Bullet;
            bulletRec = new Rectangle(x, y, width, height);
            xSpeed = 30 * (Math.Cos((bulletRotate - 90) * Math.PI / 180));
            ySpeed = 30 * (Math.Sin((bulletRotate + 90) * Math.PI / 180));
            x = playerRec.X + playerRec.Width / 2;
            y = playerRec.Y + playerRec.Height / 2;
            bulletRotated = bulletRotate;
        }
        public void drawBullet(Graphics g)
        {
            centreBullet = new Point(x, y);
            matrixBullet = new Matrix();
            matrixBullet.RotateAt(bulletRotated, centreBullet);
            g.Transform = matrixBullet;
            g.DrawImage(bullet, bulletRec);
        }
        public void moveBullet(Graphics g)
        {
            x += (int)xSpeed;
            y -= (int)ySpeed;
            bulletRec.Location = new Point(x, y);
        }
    }
}
