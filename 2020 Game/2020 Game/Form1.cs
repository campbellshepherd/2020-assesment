using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace _2020_Game
{
    public partial class Form1 : Form
    {
        Graphics g;
        Player player = new Player();
        bool turnLeft, turnRight;
        List<Bullet> bullets = new List<Bullet>();
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            player.movePlayer(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            player.drawPlayer(g);
            Cursor.Hide();
            foreach (Bullet m in bullets)
            {
                m.drawBullet(g);
                m.moveBullet(g);
            }
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                player.rotationAngle += 5;
            }
            if (turnLeft)
            {
                player.rotationAngle -= 5;
            }
            pnlGame.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
        }

        private void pnlGame_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bullets.Add(new Bullet(player.playerRec, player.rotationAngle));
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
        }
    }
}
