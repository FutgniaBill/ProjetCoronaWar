using System;
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
    public partial class FrmModifTouches : Form
    {
        //public WMPLib.WindowsMediaPlayer PlayerMT;
        public FrmModifTouches()
        {
            InitializeComponent();
            //PlayerMT = new WMPLib.WindowsMediaPlayer();
            ////Player.PlayStateChange += Player_PlayStateChange;
            //FrmParametres p = new FrmParametres();
            //p.PlayerPara.controls.stop();
            //PlayerMT.URL = "F:/Videoder/CW/2019-03-06_-_Crazy_Feelin_-_www.fesliyanstudios.com_-_David_Renda.MP3";
            //PlayerMT.controls.play();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //FrmParametres p = new FrmParametres();
            //p.PlayerPara.settings.mute=true;
            this.Hide();
            FrmParametres f = new FrmParametres();
            f.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmModifTouches_Load(object sender, EventArgs e)
        {

        }
    }
}
