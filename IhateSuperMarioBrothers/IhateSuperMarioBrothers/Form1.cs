using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IhateSuperMarioBrothers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numGems = 0;

        int gravity = 20;
        int force = 0;
        int jumpHeight = 100;

        int currentJumpHeight = 0;
        int jumpDirection = 0;

        int movementSpeed = 10;
        int enemy1MovementSpeed = 2;
        int enemy2MovementSpeed = 8;
        int playerDirection = 0;

        int platform11MovementSpeed = 2;
        int platform13MovementSpeed = 2;
        int  platformMetal1Speed = 2;

        bool playerInteract = false;
        bool playerMoveLeft;
        bool playerMoveRight;
        bool playerJump;
        bool menuStart = false;
        bool gravityState;
        bool jumping = false;
        bool touchingHouse = false;
        bool isTouchingEnemmy = false;

        Rectangle rect1;
        Rectangle rect2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void utilTick(object sender, EventArgs e)
        {
            if (playerInteract == true)
            {
                playerInteract = false;

                foreach (Control control in Controls)
                {
                    if ((string)control.Tag == "houseEnd")
                    {
                        if (pbx_player.Top >= control.Top && pbx_player.Left >= control.Left)
                        {
                            backgroundWin.BringToFront();
                            backgroundWin.Visible = true;
                        }
                    }
                }
            }

            // DialogueBox(label):
            if (playerInteract)
            {
                lbl_objective.Visible = false;
            }

            // enemy AI function calls:
            enemy1AI();
            enemy2AI();
            // platform movement function calls:
            movePlatform11();
            movePlatform13();
            movePlatformMetal1();
        }

        private void movementTick(object sender, EventArgs e) // tick for registering left to right movement
        {
            movementSpeed = 4;
            if (playerMoveLeft)
            {
                pbx_player.Left -= movementSpeed;
                pbx_player.Image = IhateSuperMarioBrothers.Properties.Resources.player_run_left;
                playerDirection = 1;
            }
            if (playerMoveRight)
            {
                pbx_player.Left += movementSpeed;
                pbx_player.Image = IhateSuperMarioBrothers.Properties.Resources.player_run_right;
                playerDirection = 0;
            }

            if (playerDirection == 1 && !playerMoveLeft)
            {
                pbx_player.Image = IhateSuperMarioBrothers.Properties.Resources.player_left;
            }
            if (playerDirection == 0 && !playerMoveRight)
            {
                pbx_player.Image = IhateSuperMarioBrothers.Properties.Resources.player;
            }
        }

        private void physicsTick(object sender, EventArgs e) // tick for registering and calculating physics interactions
        {
            if (!jumping && gravityState)
            {
                pbx_player.Top += gravity;
            }

            rect1.Y += gravity;
            if (Controls.Cast<Control>()
                    .Where(c => (string)c.Tag == "platform" && c.Bounds.IntersectsWith(rect1))
                    .ToList().Count == 0)
            {
                gravityState = true;
            }

            if (jumping)
            {
                //pbx_player.Top += gravity;
                if (jumpDirection == 1)
                {
                    bottomCollisionPlatform();

                    force = 8;
                    currentJumpHeight += force;

                    pbx_player.Top -= force;

                    if (currentJumpHeight >= jumpHeight)
                        jumpDirection = 0;
                }
                else
                {
                    pbx_player.Top += force;
                    currentJumpHeight -= force;

                    if (currentJumpHeight <= 0)
                    {
                        jumping = false;
                    }
                }
            }

            topCollisionPlatform();
            rightCollisionPlatform();
            leftCollisionPlatform();

            enemyRightCollision();
            enemyLeftCollision();
            enemyTopCollision();
        }

        // Moving certain platforms:
        private void movePlatform11()
        {
            platform11.Left -= platform11MovementSpeed;
            if (platform11.Left < 12)
            {
                platform11MovementSpeed = -2;
            }
            else if (platform11.Right > 305)
            {
                platform11MovementSpeed = 2;
            }
        }

        private void movePlatform13()
        {
            platformWood1.Top -= platform13MovementSpeed;
            if (platformWood1.Top < 320)
            {
                platform13MovementSpeed = -2;
            }
            else if (platformWood1.Top > 495+platformWood1.Height)
            {
                platform13MovementSpeed = 2;
            }
        }

        private void movePlatformMetal1()
        {
            platformMetal1.Top -= platformMetal1Speed;
            if (platformMetal1.Top < 83)
            {
                platformMetal1Speed = -2;
            }
            else if (platformMetal1.Top > 307+platformMetal1.Height)
            {
                platformMetal1Speed = 2;
            }
        }

        // Collision functions:
        private bool enemyTopCollision()
        {
            foreach (Control control in this.Controls)
            {
                rect1 = pbx_player.Bounds;
                rect2 = control.Bounds;
                if ((string)control.Tag == "enemy" && rect1.IntersectsWith(rect2) && control is PictureBox)
                {
                    Rectangle intersection = Rectangle.Intersect(rect1, rect2);

                    if (rect1.Y > rect2.Y)
                    {
                        perishedScreen.Visible = true;
                    }
                }
            }

            return isTouchingEnemmy;
        }

        private bool enemyRightCollision()
        {
            foreach (Control control in this.Controls)
            {
                rect1 = pbx_player.Bounds;
                rect2 = control.Bounds;
                if ((string)control.Tag == "enemy" && rect1.IntersectsWith(rect2) && control is PictureBox)
                {
                    Rectangle intersection = Rectangle.Intersect(rect1, rect2);

                    if (rect1.X > rect2.X)
                    {
                        perishedScreen.Visible = true;
                    }
                }
            }

            return isTouchingEnemmy;
        }

        private bool enemyLeftCollision()
        {
            foreach (Control control in this.Controls)
            {
                rect1 = pbx_player.Bounds;
                rect2 = control.Bounds;
                if ((string)control.Tag == "enemy" && rect1.IntersectsWith(rect2) && control is PictureBox)
                {
                    Rectangle intersection = Rectangle.Intersect(rect1, rect2);

                    if (rect1.X < rect2.X)
                    {
                        perishedScreen.Visible = true;
                    }
                }
            }

            return isTouchingEnemmy;
        }

        private bool topCollisionPlatform()
        {
            foreach (Control control in this.Controls)
            {
                rect1 = pbx_player.Bounds;
                rect2 = control.Bounds;
                if ((string)control.Tag == "platform" && rect1.IntersectsWith(rect2) && control is PictureBox)
                {
                    Rectangle intersection = Rectangle.Intersect(rect1, rect2);

                    if (rect1.Y < rect2.Y)
                    {
                        pbx_player.Top = control.Top - rect1.Height;
                        gravityState = false;
                        rect1.Y -= intersection.Height;
                    }
                }
            }
            return gravityState;
        }

        private int rightCollisionPlatform()
        {
            foreach (Control control in this.Controls)
            {
                rect1 = pbx_player.Bounds;
                rect2 = control.Bounds;
                if ((string)control.Tag == "platform" && rect1.IntersectsWith(rect2) && control is PictureBox)
                {
                    Rectangle intersection = Rectangle.Intersect(rect1, rect2);

                    if (rect1.X < rect2.X)
                    {
                        pbx_player.Left = control.Left - rect1.Width;
                        movementSpeed = 0;
                        rect1.X -= intersection.Width;
                    }
                }
            }

            return movementSpeed;
        }

        private int leftCollisionPlatform()
        {
            foreach (Control control in this.Controls)
            {
                rect1 = pbx_player.Bounds;
                rect2 = control.Bounds;
                if ((string)control.Tag == "platform" && rect1.IntersectsWith(rect2) && control is PictureBox)
                {
                    Rectangle intersection = Rectangle.Intersect(rect1, rect2);

                    if (rect1.X > rect2.X)
                    {
                        pbx_player.Left += intersection.Width;
                        movementSpeed = 0;
                        rect1.X += intersection.Width;
                    }
                }
            }

            return movementSpeed;
        }

        private bool bottomCollisionPlatform()
        {
            rect1 = pbx_player.Bounds;

            rect1.Y -= force;

            if (Controls.Cast<Control>()
                    .Where(c => (string)c.Tag == "platform" && c.Bounds.IntersectsWith(rect1))
                    .ToList().Count == 0)
                jumping = true;
            else
                jumpDirection = 0;

            return jumping;
        }

        // enemy functions (their behaviour and movement is included in these functions)
        private void enemy1AI()
        {
            enemy1.Left -= enemy1MovementSpeed;
            if (enemy1.Left < 240)
            {
                enemy1MovementSpeed = -2;
                enemy1.Image = IhateSuperMarioBrothers.Properties.Resources.opossum_right;
            }
            else if (enemy1.Right > 495)
            {
                enemy1MovementSpeed = 2;
                enemy1.Image = IhateSuperMarioBrothers.Properties.Resources.opossum_left;
            }

        }

        private void enemy2AI()
        {
            enemy2.Left -= enemy2MovementSpeed;
            if (enemy2.Left < 474)
            {
                enemy2MovementSpeed = -2;
                enemy2.Image = IhateSuperMarioBrothers.Properties.Resources.opossum_right;
            }
            else if (enemy2.Right > 719)
            {
                enemy2MovementSpeed = 2;
                enemy2.Image = IhateSuperMarioBrothers.Properties.Resources.opossum_left;
            }

        }

        // Key pressing registratio, this is used to register movement variables and interactio variables from the player:
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerMoveLeft = true;
                    break;

                case Keys.Right:
                    playerMoveRight = true;
                    break;

                case Keys.Z:
                    playerInteract = true;
                    break;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerMoveLeft = false;
                    break;
                case Keys.Right:
                    playerMoveRight = false;
                    break;
                case Keys.Up:
                    jumping = true;
                    jumpDirection = 1;
                    break;
                case Keys.Z:
                    playerInteract = false;
                    break;
            }
        }

        // miscellanious
        private void pbx_player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void START_Click(object sender, EventArgs e)
        {
        }

        private void STARdT_Click_1(object sender, EventArgs e)
        {

        }
    }
}

