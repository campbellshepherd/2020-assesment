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
        int ammo = 5;
        int lives = 5;
        int score=0;
        Graphics g;
        Player player = new Player();
        bool turnLeft, turnRight;
        List<Bullet> bullets = new List<Bullet>();
        List<HighScore> highScores = new List<HighScore>();
        Enemy[] enemies = new Enemy[12];
        Random yspeed = new Random();
        public Form1(string playerName)
        {
            InitializeComponent();
            lblName.Text = playerName;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            for (int i = 0; i < 12; i++)
            {
                int x = 10 + (i * 75);
                enemies[i] = new Enemy(x);
            }
            lblAmmo.Text = "5";
            LblLives.Text = "5";
            lblScore.Text = score.ToString();
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
            for (int i = 0; i < 12; i++)
            {
                int rndmspeed = yspeed.Next(1, 5);
                enemies[i].y += rndmspeed;
                enemies[i].DrawEnemy(g);
            }
            player.drawPlayer(g);
           
           
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
            if (ammo == 0)
            {
                TmrBullet.Enabled=true;
                lblAmmo.Text = "Reloading";
            }
            if (lives == 0)
            {
                TmrBullet.Enabled = false;
                tmrPlayer.Enabled = false;
                TmrEnemy.Enabled = false;
                Hide();
                FrmGameover form = new FrmGameover(score.ToString(),lblName.Text);
                form.ShowDialog();
                Cursor.Show();
                ;


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
            if (ammo > 0)
            {


                if (e.Button == MouseButtons.Left)
                {
                    bullets.Add(new Bullet(player.playerRec, player.rotationAngle));
                    ammo -= 1;
                    lblAmmo.Text = ammo.ToString();
                }
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
                    lives -= 1;
                    LblLives.Text = lives.ToString();

                }
                
                foreach (Enemy p in enemies)
                {
                    foreach (Bullet m in bullets)
                    {
                        if (p.enmyRec.IntersectsWith(m.bulletRec))
                        {
                            p.y = -20;// relocate planet to the top of the form
                            score += 1;
                            lblScore.Text = score.ToString();
                            bullets.Remove(m);
                            break;
                           


                        }
                    }
                }
            }
            
        }

        private void TmrBullet_Tick(object sender, EventArgs e)
        {
            ammo = 5;
            lblAmmo.Text = ammo.ToString();
            TmrBullet.Enabled = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pnlGame_MouseHover(object sender, EventArgs e)
        {
            Cursor.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
        }
    }
}
