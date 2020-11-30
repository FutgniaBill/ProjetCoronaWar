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
    public partial class Splashscreen2 : Form
    {
        public Splashscreen2()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 755)
            {
                timer1.Stop();
                Acceuil a = new Acceuil();
                a.Show();
                this.Hide();
                //timer1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
