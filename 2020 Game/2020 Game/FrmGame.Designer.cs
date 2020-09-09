namespace _2020_Game
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.TmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.TmrBullet = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.tmrSpeedup = new System.Windows.Forms.Timer(this.components);
            this.tmrBulletHit = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-1, 24);
            this.label1.MinimumSize = new System.Drawing.Size(835, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogre Blaster 3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlGame.Location = new System.Drawing.Point(12, 148);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(718, 394);
            this.pnlGame.TabIndex = 1;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseClick);
            this.pnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseDown);
            this.pnlGame.MouseHover += new System.EventHandler(this.pnlGame_MouseHover);
            this.pnlGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.startToolStripMenuItem.Text = "start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.stopToolStripMenuItem.Text = "stop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(748, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lives";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Score";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(749, 172);
            this.lblName.MinimumSize = new System.Drawing.Size(70, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 30);
            this.lblName.TabIndex = 6;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.BackColor = System.Drawing.Color.White;
            this.LblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLives.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblLives.Location = new System.Drawing.Point(749, 269);
            this.LblLives.MinimumSize = new System.Drawing.Size(70, 30);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(70, 30);
            this.LblLives.TabIndex = 7;
            this.LblLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblScore.Location = new System.Drawing.Point(749, 357);
            this.lblScore.MinimumSize = new System.Drawing.Size(70, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 30);
            this.lblScore.TabIndex = 8;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Enabled = true;
            this.tmrPlayer.Interval = 1;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // TmrEnemy
            // 
            this.TmrEnemy.Enabled = true;
            this.TmrEnemy.Interval = 30;
            this.TmrEnemy.Tick += new System.EventHandler(this.TmrEnemy_Tick);
            // 
            // TmrBullet
            // 
            this.TmrBullet.Interval = 750;
            this.TmrBullet.Tick += new System.EventHandler(this.TmrBullet_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(748, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ammo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.BackColor = System.Drawing.Color.White;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAmmo.Location = new System.Drawing.Point(748, 471);
            this.lblAmmo.MinimumSize = new System.Drawing.Size(70, 30);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(70, 30);
            this.lblAmmo.TabIndex = 10;
            this.lblAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSpeedup
            // 
            this.tmrSpeedup.Enabled = true;
            this.tmrSpeedup.Interval = 10000;
            this.tmrSpeedup.Tick += new System.EventHandler(this.tmrSpeedup_Tick);
            // 
            // tmrBulletHit
            // 
            this.tmrBulletHit.Enabled = true;
            this.tmrBulletHit.Interval = 1;
            this.tmrBulletHit.Tick += new System.EventHandler(this.tmrBulletHit_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(834, 551);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.Timer TmrEnemy;
        private System.Windows.Forms.Timer TmrBullet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Timer tmrSpeedup;
        private System.Windows.Forms.Timer tmrBulletHit;
    }
}

