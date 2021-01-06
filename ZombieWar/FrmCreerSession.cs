using CW.BLL;
using CW.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieWar
{
    public partial class FrmCreerSession : Form
    {
        private Action callBack;
        private Session oldSession;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int RightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeighEllipse
           );
        public WMPLib.WindowsMediaPlayer Player;

        public FrmCreerSession(Session session, Action callBack) : this(callBack)
        {
            this.oldSession = session;
            gunaTextBoxPseudo.Text = session.Pseudo;
            gunaComboBoxSexe.Text = session.Sexe;
            bunifuCustomLabelScore.Text = session.Score.ToString();
            if (session.Photo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(session.Photo));
        }
        public FrmCreerSession()
        {
            InitializeComponent();
           // Player = new WMPLib.WindowsMediaPlayer();
           //// Player.PlayStateChange += Player_PlayStateChange;
           // Player.URL = "F:/Videoder/CW/2019-03-06_-_Crazy_Feelin_-_www.fesliyanstudios.com_-_David_Renda.MP3";
           // Player.controls.play();
        }
        public FrmCreerSession(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Player.controls.stop();
            FrmSession s = new FrmSession();
            this.Hide();
            s.Show();

        }

        private void FrmCreerSession_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            bunifuCircleProgressbar1.Text = bunifuCircleProgressbar1.ToString() + "%";
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Enabled = false;
                bunifuCircleProgressbar1.Visible = false;
                gunaButtonCancel.Visible = true;
                gunaButtonSave.Visible = true;
                pictureBox1.Visible = true;
                gunaComboBoxSexe.Visible = true;
                gunaTextBoxPseudo.Visible = true;
                gunaComboBoxSexe.Visible = true;
                bunifuCustomLabel1.Visible = true;
                bunifuCustomLabel2.Visible = true;
                bunifuCustomLabel3.Visible = true;
                lblLang.Visible = true;
                bunifuCustomLabelScore.Visible = true;
                btnExit.Visible = true;
            }
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void gunaButtonCancel_Click(object sender, EventArgs e)
        {
            FrmSession s = new FrmSession();
            this.Hide();
            s.Show();
        }
        private void checkForm()
        {
            string text = string.Empty;
            gunaTextBoxPseudo.BackColor = Color.AliceBlue;
            if (string.IsNullOrWhiteSpace(gunaTextBoxPseudo.Text))
            {
                text += "- Please enter the reference ! \n";
                gunaTextBoxPseudo.BackColor = Color.Maroon;
            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }
        private void gunaButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                string filename = null;
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))//hum
                {
                    string ext = Path.GetExtension(pictureBox1.ImageLocation);
                    filename = Guid.NewGuid().ToString() + ext;
                    FileInfo fileSource = new FileInfo(pictureBox1.ImageLocation);
                    string filePath = Path.Combine(ConfigurationManager.AppSettings["DbFolder"], "logo", filename);
                    FileInfo fileDest = new FileInfo(filePath);
                    if (!fileDest.Directory.Exists)
                        fileDest.Directory.Create();
                    fileSource.CopyTo(fileDest.FullName);
                }
                Session newSession = new Session(
                    gunaTextBoxPseudo.Text,
                    gunaComboBoxSexe.Text,
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldSession?.Photo,
                    long.Parse(bunifuCustomLabelScore.Text)
                    );
                SessionBLO eblo = new SessionBLO(ConfigurationManager.AppSettings["DbFolder"]);
                if (this.oldSession == null)
                    eblo.CreateSession(newSession);
                else
                    eblo.EditSession(oldSession, newSession);
                MessageBox.Show(
                    "Save done !",
                     "Confirm",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                    );
                if (callBack != null)
                    callBack();
                if (oldSession != null)
                    Close();
                //gunaCirclePictureBox1. ;
                gunaTextBoxPseudo.Clear();
                bunifuCustomLabelScore.Text= "0000";
                gunaTextBoxPseudo.Focus();
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
              (
                  ex.Message,
                  "Duplicate error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
              );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }

        }

        private void gunaComboBoxSexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}

