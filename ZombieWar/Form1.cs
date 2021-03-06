﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieWar
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, goLeft, goRight, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10; 
        int ammo = 10; 
        int zombieSpeed = 3; 
        int score = 0;
        Random randNum = new Random();
        List<PictureBox> ZombiesList = new List<PictureBox>();

        public WMPLib.WindowsMediaPlayer PlayerF;

        public Form1()
        {
            InitializeComponent();
           // PlayerF = new WMPLib.WindowsMediaPlayer();
           //// Player.PlayStateChange += Player_PlayStateChange;
           // PlayerF.URL = "F:/Videoder/CW/2019-03-06_-_Crazy_Feelin_-_www.fesliyanstudios.com_-_David_Renda.MP3";
           // PlayerF.controls.play();
           RestartGame();
        }

        private void MainTimerEvents(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                Gametimer.Stop();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            if(goLeft==true && player.Left >0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }


            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag=="ammo")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }




                if(x is PictureBox && (string) x.Tag == "zombie")
                {

                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if(x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }

                }

                foreach(Control j in this.Controls)
                {
                    if(j is PictureBox && (string)j.Tag=="bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if(x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            ZombiesList.Remove(((PictureBox)x));
                            MakeZombies();
                        }
                    }
                }
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if(gameOver==true)
            {
                return;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true; 
                facing = "left"; 
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true; 
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                facing = "up";
                goUp = true;
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
                goDown = true;
                player.Image = Properties.Resources.down;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                Shootbullet(facing);

                if(ammo < 1)
                {
                    DropAmmo();
                }
            }

            if(e.KeyCode==Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void healthBar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //PlayerF.controls.stop();
            Acceuil a = new Acceuil();
            this.Hide();
            a.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //PlayerF.controls.stop();
        }

        private void Shootbullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletleft = player.Left + (player.Width / 2);
            shootBullet.bullettop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }
        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 800);
            zombie.Top = randNum.Next(0, 600);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            ZombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();

        }
        private void RestartGame()
        {
            player.Image = Properties.Resources.up;
            foreach(PictureBox i in ZombiesList)
            {
                this.Controls.Remove(i);
            }

            ZombiesList.Clear();
            for(int i=0; i <3; i++)
            {
                MakeZombies();
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            Gametimer.Start();
        }
    }
}
