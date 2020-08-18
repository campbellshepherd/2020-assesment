﻿using System;
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
        Enemy[] enemies = new Enemy[12];
        Random yspeed = new Random();
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            for (int i = 0; i < 12; i++)
            {
                int x = 10 + (i * 75);
                enemies[i] = new Enemy(x);
            }
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
            for (int i = 0; i < 12; i++)
            {
                int rndmspeed = yspeed.Next(1, 5);
                enemies[i].y += rndmspeed;
                enemies[i].DrawEnemy(g);
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

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                enemies[i].MoveEnemy();
                if (enemies[i].y >= pnlGame.Height)
                {
                    enemies[i].y = 30;
                }
                if (player.playerRec.IntersectsWith(enemies[i].enmyRec))
                {
                    enemies[i].y = 30;
                }
                foreach (Enemy p in enemies)
                {
                    foreach (Bullet m in bullets)
                    {
                        if (p.enmyRec.IntersectsWith(m.bulletRec))
                        {
                            p.y = -20;// relocate planet to the top of the form

                            bullets.Remove(m);
                            break;
                        }
                    }
                }
            }
            
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
        }
    }
}
