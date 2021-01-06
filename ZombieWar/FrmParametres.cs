using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;

namespace ZombieWar
{
    public partial class FrmParametres : Form
    {
        //1/private System.Media.SoundPlayer player;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeighEllipse
            );
        public WMPLib.WindowsMediaPlayer PlayerPara;
        public FrmParametres()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            bunifuCircleProgressbar1.Value = 0;
            //1/player = new System.Media.SoundPlayer();
            //PlayerPara = new WMPLib.WindowsMediaPlayer();
            //PlayerPara.controls.stop();
            //PlayerPara.PlayStateChange += Player_PlayStateChange;
            //PlayerPara.URL = "F:/Videoder/CW/2019-03-06_-_Crazy_Feelin_-_www.fesliyanstudios.com_-_David_Renda.MP3";
            //PlayerPara.controls.play();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //PlayerPara.settings.mute = true;
            //PlayerPara.controls.stop();
            this.Hide();
            Acceuil f = new Acceuil();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            bunifuCircleProgressbar1.Text = bunifuCircleProgressbar1.ToString() + "%";
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Enabled = false;
                bunifuCircleProgressbar1.Visible = false;
                lblDiffi.Visible = true;
                lblLang.Visible = true;
                lblTouch.Visible = true;
                lblVolume.Visible = true;
                gunaButtonModify.Visible = true;
                gunaComboBoxDiffi.Visible = true;
                gunaComboBoxLangue.Visible = true;
                gunaTrackBar1.Visible = true;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmParametres_Load(object sender, EventArgs e)
        {
            //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            //wplayer.URL = "F:/Videoder/Opening&Ending/Boku_No_Hero_Academia_Opening_2(128k).MP3";
            //wplayer.controls.play();

        }
        public void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //Actions on stop
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //PlayerPara.enabled = false;
            //PlayerPara.controls.stop();
            this.Hide();
            FrmModifTouches f = new FrmModifTouches();
            f.Show();

        }

        private void gunaTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Acceuil a = new Acceuil();
            //PlayerPara.controls.stop();
            a.Player.settings.volume = gunaTrackBar1.Value;
            if (gunaTrackBar1.Value == 0)
            {
                a.Player.settings.mute = true;
            }
        }

        private void gunaComboBoxLangue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
