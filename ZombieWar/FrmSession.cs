using CW.BLL;
using CW.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieWar
{
    public partial class FrmSession : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int RightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeighEllipse
           );

        private SessionBLO sessionBLO;
        public FrmSession()
        {
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            sessionBLO = new SessionBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        //private void loadData()
        //{
        //    string value = Search.Text.ToLower();
        //    var etudiants = sessionBLO.GetBy
        //    (x =>
        //     x.Pseudo.ToLower().Contains(value)
        //    ).OrderBy(x => x.Score).ToArray();
        //    gunaDataGridView1.DataSource = null;
        //    gunaDataGridView1.DataSource = etudiants;
        //    gunaDataGridView1.ClearSelection();
        //}
        private void loadData()
        {
            string value = gunaTextBox1.Text.ToLower();
            var etudiants = sessionBLO.GetBy
            (x =>
             x.Pseudo.ToLower().Contains(value)
            ).OrderByDescending(x => x.Score).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = etudiants;
            dataGridView1.ClearSelection();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gunaButtonModif_Click(sender, e);
        }
        private void gunaDataFridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gunaButtonModif_Click(sender, e);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Acceuil a = new Acceuil();
            a.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            bunifuCircleProgressbar1.Text = bunifuCircleProgressbar1.ToString() + "%";
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Enabled = false;
                bunifuCircleProgressbar1.Visible = false;
                Search.Visible = true;
                dataGridView1.Visible = true;
                gunaTextBox1.Visible = true;
                gunaButtonVue.Visible = true;
                gunaButtonCreer.Visible = true;
                gunaButtonModif.Visible = true;
                gunaButtonSupprimer.Visible = true;
                btnExit.Visible = true;
            }
        }

        private void gunaButtonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this session(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        sessionBLO.DeleteSession(dataGridView1.SelectedRows[i].DataBoundItem as Session);
                    }
                    loadData();
                }
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void gunaButtonCreer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gunaTextBox1.Text))
                loadData();
            else
                gunaTextBox1.Clear();
            FrmCreerSession f = new FrmCreerSession(loadData);
            this.Hide();
            f.Show();
        }

        private void gunaButtonVue_Click(object sender, EventArgs e)
        {

        }

        private void gunaButtonModif_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmCreerSession
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Session,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void FrmSession_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
