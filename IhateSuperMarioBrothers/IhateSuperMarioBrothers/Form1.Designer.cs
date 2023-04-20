namespace IhateSuperMarioBrothers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_physics = new System.Windows.Forms.Timer(this.components);
            this.timer_movement = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.pbx_player = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.utilTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picturebox1111 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.platformWood1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.platform11 = new System.Windows.Forms.PictureBox();
            this.platformMetal1 = new System.Windows.Forms.PictureBox();
            this.platformBig13 = new System.Windows.Forms.PictureBox();
            this.backgroundWin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.perishedScreen = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.lbl_objective = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformWood1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformMetal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformBig13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perishedScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_physics
            // 
            this.timer_physics.Enabled = true;
            this.timer_physics.Interval = 1;
            this.timer_physics.Tick += new System.EventHandler(this.physicsTick);
            // 
            // timer_movement
            // 
            this.timer_movement.Enabled = true;
            this.timer_movement.Interval = 1;
            this.timer_movement.Tick += new System.EventHandler(this.movementTick);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.Location = new System.Drawing.Point(0, 677);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1195, 47);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            this.ground.Tag = "platform";
            this.ground.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbx_player
            // 
            this.pbx_player.BackColor = System.Drawing.Color.Transparent;
            this.pbx_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_player.Image = global::IhateSuperMarioBrothers.Properties.Resources.player;
            this.pbx_player.Location = new System.Drawing.Point(71, 631);
            this.pbx_player.Name = "pbx_player";
            this.pbx_player.Size = new System.Drawing.Size(53, 43);
            this.pbx_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_player.TabIndex = 1;
            this.pbx_player.TabStop = false;
            this.pbx_player.Click += new System.EventHandler(this.pbx_player_Click);
            // 
            // house
            // 
            this.house.BackColor = System.Drawing.Color.Transparent;
            this.house.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("house.BackgroundImage")));
            this.house.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.house.Location = new System.Drawing.Point(1108, 470);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(145, 210);
            this.house.TabIndex = 6;
            this.house.TabStop = false;
            this.house.Tag = "houseEnd";
            // 
            // utilTimer
            // 
            this.utilTimer.Enabled = true;
            this.utilTimer.Interval = 1;
            this.utilTimer.Tick += new System.EventHandler(this.utilTick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(857, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 95);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(768, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(290, 665);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // picturebox1111
            // 
            this.picturebox1111.BackColor = System.Drawing.Color.Transparent;
            this.picturebox1111.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturebox1111.BackgroundImage")));
            this.picturebox1111.Location = new System.Drawing.Point(249, 631);
            this.picturebox1111.Name = "picturebox1111";
            this.picturebox1111.Size = new System.Drawing.Size(289, 113);
            this.picturebox1111.TabIndex = 11;
            this.picturebox1111.TabStop = false;
            this.picturebox1111.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(556, 585);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // platformWood1
            // 
            this.platformWood1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platformWood1.BackgroundImage")));
            this.platformWood1.Location = new System.Drawing.Point(649, 495);
            this.platformWood1.Name = "platformWood1";
            this.platformWood1.Size = new System.Drawing.Size(100, 31);
            this.platformWood1.TabIndex = 13;
            this.platformWood1.TabStop = false;
            this.platformWood1.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(459, 457);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 30);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(304, 437);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(97, 33);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(135, 437);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(94, 17);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(12, 436);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(124, 34);
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.Location = new System.Drawing.Point(71, 336);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 15);
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // platform11
            // 
            this.platform11.BackColor = System.Drawing.Color.Transparent;
            this.platform11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform11.BackgroundImage")));
            this.platform11.Location = new System.Drawing.Point(160, 245);
            this.platform11.Name = "platform11";
            this.platform11.Size = new System.Drawing.Size(100, 31);
            this.platform11.TabIndex = 19;
            this.platform11.TabStop = false;
            this.platform11.Tag = "platform";
            // 
            // platformMetal1
            // 
            this.platformMetal1.BackColor = System.Drawing.Color.Transparent;
            this.platformMetal1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platformMetal1.BackgroundImage")));
            this.platformMetal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platformMetal1.Location = new System.Drawing.Point(341, 83);
            this.platformMetal1.Name = "platformMetal1";
            this.platformMetal1.Size = new System.Drawing.Size(26, 24);
            this.platformMetal1.TabIndex = 20;
            this.platformMetal1.TabStop = false;
            this.platformMetal1.Tag = "platform";
            // 
            // platformBig13
            // 
            this.platformBig13.BackColor = System.Drawing.Color.Transparent;
            this.platformBig13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platformBig13.BackgroundImage")));
            this.platformBig13.Location = new System.Drawing.Point(474, 193);
            this.platformBig13.Name = "platformBig13";
            this.platformBig13.Size = new System.Drawing.Size(288, 50);
            this.platformBig13.TabIndex = 21;
            this.platformBig13.TabStop = false;
            this.platformBig13.Tag = "platform";
            // 
            // backgroundWin
            // 
            this.backgroundWin.BackColor = System.Drawing.Color.Transparent;
            this.backgroundWin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundWin.BackgroundImage")));
            this.backgroundWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundWin.Location = new System.Drawing.Point(0, -3);
            this.backgroundWin.Name = "backgroundWin";
            this.backgroundWin.Size = new System.Drawing.Size(1207, 747);
            this.backgroundWin.TabIndex = 22;
            this.backgroundWin.TabStop = false;
            this.backgroundWin.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "\"Z\" to interact";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Image = global::IhateSuperMarioBrothers.Properties.Resources.opossum_left;
            this.enemy1.Location = new System.Drawing.Point(404, 601);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(43, 31);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 24;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // perishedScreen
            // 
            this.perishedScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("perishedScreen.BackgroundImage")));
            this.perishedScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.perishedScreen.Location = new System.Drawing.Point(0, 1);
            this.perishedScreen.Name = "perishedScreen";
            this.perishedScreen.Size = new System.Drawing.Size(1195, 723);
            this.perishedScreen.TabIndex = 26;
            this.perishedScreen.TabStop = false;
            this.perishedScreen.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Image = global::IhateSuperMarioBrothers.Properties.Resources.opossum_left;
            this.enemy2.Location = new System.Drawing.Point(719, 165);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(43, 31);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 27;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // lbl_objective
            // 
            this.lbl_objective.AutoSize = true;
            this.lbl_objective.BackColor = System.Drawing.Color.Transparent;
            this.lbl_objective.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objective.Location = new System.Drawing.Point(23, 585);
            this.lbl_objective.Name = "lbl_objective";
            this.lbl_objective.Size = new System.Drawing.Size(280, 21);
            this.lbl_objective.TabIndex = 28;
            this.lbl_objective.Text = "I need to get to my friends house!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1195, 724);
            this.Controls.Add(this.perishedScreen);
            this.Controls.Add(this.backgroundWin);
            this.Controls.Add(this.platformBig13);
            this.Controls.Add(this.platformMetal1);
            this.Controls.Add(this.platform11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.platformWood1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picturebox1111);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pbx_player);
            this.Controls.Add(this.house);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.lbl_objective);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformWood1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformMetal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platformBig13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perishedScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_physics;
        private System.Windows.Forms.Timer timer_movement;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pbx_player;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.Timer utilTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picturebox1111;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox platformWood1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox platform11;
        private System.Windows.Forms.PictureBox platformMetal1;
        private System.Windows.Forms.PictureBox platformBig13;
        private System.Windows.Forms.PictureBox backgroundWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox perishedScreen;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label lbl_objective;
    }
}

