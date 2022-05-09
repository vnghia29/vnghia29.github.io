﻿
namespace T_Rex_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Trex = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtHighScore = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.BirdTimer1 = new System.Windows.Forms.Timer(this.components);
            this.BirdTimer2 = new System.Windows.Forms.Timer(this.components);
            this.TrexDown = new System.Windows.Forms.PictureBox();
            this.TrexDTimer1 = new System.Windows.Forms.Timer(this.components);
            this.TrexDTimer2 = new System.Windows.Forms.Timer(this.components);
            this.TrexUpTimer = new System.Windows.Forms.Timer(this.components);
            this.khien = new System.Windows.Forms.PictureBox();
            this.txtKhien = new System.Windows.Forms.Label();
            this.shield_timer = new System.Windows.Forms.Timer(this.components);
            this.fireBall = new System.Windows.Forms.PictureBox();
            this.fireballTimer = new System.Windows.Forms.Timer(this.components);
            this.firerTimer = new System.Windows.Forms.Timer(this.components);
            this.firer = new System.Windows.Forms.PictureBox();
            this.txtFirer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrexDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firer)).BeginInit();
            this.SuspendLayout();
            // 
            // Trex
            // 
            this.Trex.Image = global::T_Rex_Game.Properties.Resources.running;
            this.Trex.Location = new System.Drawing.Point(133, 349);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(40, 43);
            this.Trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Trex.TabIndex = 1;
            this.Trex.TabStop = false;
            this.Trex.Tag = "trex";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::T_Rex_Game.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(454, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::T_Rex_Game.Properties.Resources.obstacle_2;
            this.pictureBox4.Location = new System.Drawing.Point(577, 359);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle2";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(13, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(135, 33);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHighScore.Location = new System.Drawing.Point(13, 55);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(195, 33);
            this.txtHighScore.TabIndex = 5;
            this.txtHighScore.Text = "HighScore: 0";
            // 
            // refresh
            // 
            this.refresh.Image = global::T_Rex_Game.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(360, 204);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(55, 46);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.refresh.TabIndex = 6;
            this.refresh.TabStop = false;
            this.refresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.refresh_MouseClick);
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGameOver.Location = new System.Drawing.Point(276, 158);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(220, 32);
            this.lbGameOver.TabIndex = 7;
            this.lbGameOver.Text = "G a m e  O v e r\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "ground";
            // 
            // Bird
            // 
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(615, 268);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(47, 34);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bird.TabIndex = 8;
            this.Bird.TabStop = false;
            this.Bird.Tag = "bird";
            // 
            // BirdTimer1
            // 
            this.BirdTimer1.Interval = 30;
            this.BirdTimer1.Tick += new System.EventHandler(this.BirdTimer1_Tick);
            // 
            // BirdTimer2
            // 
            this.BirdTimer2.Interval = 30;
            this.BirdTimer2.Tick += new System.EventHandler(this.BirdTimer2_Tick);
            // 
            // TrexDown
            // 
            this.TrexDown.Image = global::T_Rex_Game.Properties.Resources.trexdown1;
            this.TrexDown.Location = new System.Drawing.Point(133, 363);
            this.TrexDown.Name = "TrexDown";
            this.TrexDown.Size = new System.Drawing.Size(57, 28);
            this.TrexDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TrexDown.TabIndex = 9;
            this.TrexDown.TabStop = false;
            // 
            // TrexDTimer1
            // 
            this.TrexDTimer1.Interval = 90;
            this.TrexDTimer1.Tick += new System.EventHandler(this.TrexDTimer1_Tick);
            // 
            // TrexDTimer2
            // 
            this.TrexDTimer2.Tick += new System.EventHandler(this.TrexDTimer2_Tick);
            // 
            // TrexUpTimer
            // 
            this.TrexUpTimer.Tick += new System.EventHandler(this.TrexUpTimer_Tick);
            // 
            // khien
            // 
            this.khien.Location = new System.Drawing.Point(763, 346);
            this.khien.Name = "khien";
            this.khien.Size = new System.Drawing.Size(28, 31);
            this.khien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.khien.TabIndex = 10;
            this.khien.TabStop = false;
            this.khien.Tag = "khien";
            // 
            // txtKhien
            // 
            this.txtKhien.AutoSize = true;
            this.txtKhien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKhien.Location = new System.Drawing.Point(724, 26);
            this.txtKhien.Name = "txtKhien";
            this.txtKhien.Size = new System.Drawing.Size(0, 25);
            this.txtKhien.TabIndex = 11;
            // 
            // shield_timer
            // 
            this.shield_timer.Interval = 30;
            this.shield_timer.Tick += new System.EventHandler(this.shield_timer_Tick);
            // 
            // fireBall
            // 
            this.fireBall.Location = new System.Drawing.Point(704, 346);
            this.fireBall.Name = "fireBall";
            this.fireBall.Size = new System.Drawing.Size(20, 24);
            this.fireBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fireBall.TabIndex = 12;
            this.fireBall.TabStop = false;
            this.fireBall.Tag = "fireBall";
            // 
            // fireballTimer
            // 
            this.fireballTimer.Interval = 30;
            this.fireballTimer.Tick += new System.EventHandler(this.fireballTimer_Tick);
            // 
            // firerTimer
            // 
            this.firerTimer.Interval = 30;
            this.firerTimer.Tick += new System.EventHandler(this.firerTimer_Tick);
            // 
            // firer
            // 
            this.firer.Image = global::T_Rex_Game.Properties.Resources.Fire_Ball;
            this.firer.Location = new System.Drawing.Point(153, 349);
            this.firer.Name = "firer";
            this.firer.Size = new System.Drawing.Size(20, 24);
            this.firer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.firer.TabIndex = 13;
            this.firer.TabStop = false;
            this.firer.Tag = "firer";
            // 
            // txtFirer
            // 
            this.txtFirer.AutoSize = true;
            this.txtFirer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFirer.Location = new System.Drawing.Point(704, 82);
            this.txtFirer.Name = "txtFirer";
            this.txtFirer.Size = new System.Drawing.Size(63, 25);
            this.txtFirer.TabIndex = 14;
            this.txtFirer.Text = "Fire: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.txtFirer);
            this.Controls.Add(this.txtKhien);
            this.Controls.Add(this.TrexDown);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.khien);
            this.Controls.Add(this.Trex);
            this.Controls.Add(this.fireBall);
            this.Controls.Add(this.firer);
            this.Name = "Form1";
            this.Text = "T-Rex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrexDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox Trex;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Timer BirdTimer1;
        private System.Windows.Forms.Timer BirdTimer2;
        private System.Windows.Forms.PictureBox TrexDown;
        private System.Windows.Forms.Timer TrexDTimer1;
        private System.Windows.Forms.Timer TrexDTimer2;
        private System.Windows.Forms.Timer TrexUpTimer;
        private System.Windows.Forms.PictureBox khien;
        private System.Windows.Forms.Label txtKhien;
        private System.Windows.Forms.Timer shield_timer;
        private System.Windows.Forms.PictureBox fireBall;
        private System.Windows.Forms.Timer fireballTimer;
        private System.Windows.Forms.Timer firerTimer;
        private System.Windows.Forms.PictureBox firer;
        private System.Windows.Forms.Label txtFirer;
    }
}

