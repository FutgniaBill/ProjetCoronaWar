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
    public partial class Splashscreen1 : Form
    {
        public Splashscreen1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Splashscreen2 s = new Splashscreen2();
            s.Show();
            timer1.Enabled = false;
        }
    }
}
