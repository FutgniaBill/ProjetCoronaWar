using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ZombieWar
{
    public partial class Acceuil : Form
    {
        public WMPLib.WindowsMediaPlayer Player;

        public Acceuil()
        {
            InitializeComponent();
            
            Player = new WMPLib.WindowsMediaPlayer();
            Player.controls.stop();
            Player.PlayStateChange += Player_PlayStateChange;
            Player.URL = "F:/Videoder/CW/2019-03-06_-_Crazy_Feelin_-_www.fesliyanstudios.com_-_David_Renda.MP3";
            Player.settings.setMode("loop", true);
            Player.controls.play();

        }
        public void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //Actions on stop
                FrmParametres f = new FrmParametres();
                Player.settings.volume = f.gunaTrackBar1.Value;
            }
        }

        private void btnNouvPartie_Click(object sender, EventArgs e)
        { 
            //Player.controls.stop();
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            //Player.controls.stop();
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            //Player.controls.stop();
            this.Hide();
            FrmParametres n = new FrmParametres();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Player.controls.stop();
            FrmSession f = new FrmSession();
            this.Hide();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }
    }
}
