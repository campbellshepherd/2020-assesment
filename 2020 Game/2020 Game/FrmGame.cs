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
using System.Media;

namespace _2020_Game
{
    public partial class FrmGame : Form
    {
        int speedup;
        int ammo = 7;
        int lives = 5;
        int score=0;
        Graphics g;
        Player player = new Player();
        bool turnLeft, turnRight;
        List<Bullet> bullets = new List<Bullet>();
        List<HighScore> highScores = new List<HighScore>();
        Enemy[] enemies = new Enemy[12];
        EnemyBottom[] enemiesBottom = new EnemyBottom[12];
        Random yspeed = new Random();
        
        public FrmGame(string playerName)
        {
            InitializeComponent();
            lblName.Text = playerName;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            for (int i = 0; i < 12; i++)
            {
                int x = 10 + (i * 75);
                enemies[i] = new Enemy(x);
            }
            for (int i = 0; i < 12; i++)
            {
                int x = 10 + (i * 75);
                enemiesBottom[i] = new EnemyBottom(x);
            }
            lblAmmo.Text = "7";
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
               
                enemies[i].DrawEnemy(g);
                
                enemiesBottom[i].DrawEnemy(g);
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
            if (lives < 1)
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
                    SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Shoot);
                    simpleSound.Play();
                }
            }
        }

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 12; i++)
            {
                int rndmspeed = yspeed.Next(1, 4);
                enemies[i].y += rndmspeed + speedup;
                enemiesBottom[i].y -= rndmspeed + speedup;
                enemiesBottom[i].MoveEnemy();
                enemies[i].MoveEnemy();
                if (enemies[i].y >= pnlGame.Height)
                {
                    enemies[i].y = 30;
                    score += 1;
                    lblScore.Text = score.ToString();
                }
                if (enemiesBottom[i].y < 0)
                {
                    enemiesBottom[i].y = 350;
                    score += 1;
                    lblScore.Text = score.ToString();

                }
                if (player.playerRec.IntersectsWith(enemies[i].enmyRec))
                {
                    enemies[i].y = 30;
                    lives -= 1;
                    LblLives.Text = lives.ToString();

                }
                if (player.playerRec.IntersectsWith(enemiesBottom[i].enmyRec))
                {
                    enemiesBottom[i].y = 30;
                    lives -= 1;
                    LblLives.Text = lives.ToString();

                }

              
            }
            
        }

        private void TmrBullet_Tick(object sender, EventArgs e)
        {
           
            ammo = 7;
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

        private void tmrSpeedup_Tick(object sender, EventArgs e)
        {
            speedup += 1;
        }

        private void tmrBulletHit_Tick(object sender, EventArgs e)
        {
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
            foreach (EnemyBottom p in enemiesBottom)
            {
                foreach (Bullet m in bullets)
                {
                    if (p.enmyRec.IntersectsWith(m.bulletRec))
                    {
                        p.y = 400;// relocate planet to the top of the form
                        score += 1;
                        lblScore.Text = score.ToString();
                        bullets.Remove(m);
                        break;
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
