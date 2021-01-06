namespace ZombieWar
{
    partial class FrmParametres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametres));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDiffi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTouch = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLang = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblVolume = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gunaComboBoxDiffi = new Guna.UI.WinForms.GunaComboBox();
            this.gunaComboBoxLangue = new Guna.UI.WinForms.GunaComboBox();
            this.gunaTrackBar1 = new Guna.UI.WinForms.GunaTrackBar();
            this.gunaButtonModify = new Guna.UI.WinForms.GunaButton();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 100);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paramètres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDiffi
            // 
            this.lblDiffi.AutoSize = true;
            this.lblDiffi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiffi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffi.ForeColor = System.Drawing.Color.White;
            this.lblDiffi.Location = new System.Drawing.Point(38, 129);
            this.lblDiffi.Name = "lblDiffi";
            this.lblDiffi.Size = new System.Drawing.Size(120, 31);
            this.lblDiffi.TabIndex = 12;
            this.lblDiffi.Text = "Difficulté";
            this.lblDiffi.Visible = false;
            // 
            // lblTouch
            // 
            this.lblTouch.AutoSize = true;
            this.lblTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTouch.ForeColor = System.Drawing.Color.White;
            this.lblTouch.Location = new System.Drawing.Point(38, 325);
            this.lblTouch.Name = "lblTouch";
            this.lblTouch.Size = new System.Drawing.Size(119, 31);
            this.lblTouch.TabIndex = 13;
            this.lblTouch.Text = "Touches";
            this.lblTouch.Visible = false;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.White;
            this.lblLang.Location = new System.Drawing.Point(38, 199);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(104, 31);
            this.lblLang.TabIndex = 14;
            this.lblLang.Text = "Langue";
            this.lblLang.Visible = false;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(38, 264);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(105, 31);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "Volume";
            this.lblVolume.Visible = false;
            // 
            // gunaComboBoxDiffi
            // 
            this.gunaComboBoxDiffi.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxDiffi.BaseColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxDiffi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaComboBoxDiffi.DisplayMember = "Débutant";
            this.gunaComboBoxDiffi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBoxDiffi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBoxDiffi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaComboBoxDiffi.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBoxDiffi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaComboBoxDiffi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaComboBoxDiffi.FormattingEnabled = true;
            this.gunaComboBoxDiffi.Items.AddRange(new object[] {
            "Débutant",
            "Facile",
            "Moyen",
            "Difficile",
            "Impossible"});
            this.gunaComboBoxDiffi.Location = new System.Drawing.Point(164, 134);
            this.gunaComboBoxDiffi.Name = "gunaComboBoxDiffi";
            this.gunaComboBoxDiffi.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.gunaComboBoxDiffi.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBoxDiffi.Radius = 20;
            this.gunaComboBoxDiffi.Size = new System.Drawing.Size(257, 28);
            this.gunaComboBoxDiffi.StartIndex = 0;
            this.gunaComboBoxDiffi.TabIndex = 16;
            this.gunaComboBoxDiffi.Visible = false;
            // 
            // gunaComboBoxLangue
            // 
            this.gunaComboBoxLangue.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxLangue.BaseColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxLangue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaComboBoxLangue.DisplayMember = "Débutant";
            this.gunaComboBoxLangue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBoxLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBoxLangue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaComboBoxLangue.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBoxLangue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaComboBoxLangue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaComboBoxLangue.FormattingEnabled = true;
            this.gunaComboBoxLangue.Items.AddRange(new object[] {
            "Français / French",
            "English / Anglais"});
            this.gunaComboBoxLangue.Location = new System.Drawing.Point(164, 202);
            this.gunaComboBoxLangue.Name = "gunaComboBoxLangue";
            this.gunaComboBoxLangue.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.gunaComboBoxLangue.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBoxLangue.Radius = 20;
            this.gunaComboBoxLangue.Size = new System.Drawing.Size(257, 28);
            this.gunaComboBoxLangue.StartIndex = 0;
            this.gunaComboBoxLangue.TabIndex = 17;
            this.gunaComboBoxLangue.Visible = false;
            this.gunaComboBoxLangue.SelectedIndexChanged += new System.EventHandler(this.gunaComboBoxLangue_SelectedIndexChanged);
            // 
            // gunaTrackBar1
            // 
            this.gunaTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTrackBar1.Location = new System.Drawing.Point(164, 271);
            this.gunaTrackBar1.Name = "gunaTrackBar1";
            this.gunaTrackBar1.Size = new System.Drawing.Size(248, 23);
            this.gunaTrackBar1.TabIndex = 19;
            this.gunaTrackBar1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaTrackBar1.TrackHoverColor = System.Drawing.Color.SeaShell;
            this.gunaTrackBar1.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaTrackBar1.TrackPressedColor = System.Drawing.Color.Transparent;
            this.gunaTrackBar1.Visible = false;
            this.gunaTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaTrackBar1_Scroll);
            // 
            // gunaButtonModify
            // 
            this.gunaButtonModify.AnimationHoverSpeed = 0.07F;
            this.gunaButtonModify.AnimationSpeed = 0.03F;
            this.gunaButtonModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaButtonModify.BaseColor = System.Drawing.Color.Empty;
            this.gunaButtonModify.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonModify.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonModify.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonModify.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButtonModify.ForeColor = System.Drawing.Color.White;
            this.gunaButtonModify.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonModify.Image")));
            this.gunaButtonModify.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonModify.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaButtonModify.Location = new System.Drawing.Point(164, 325);
            this.gunaButtonModify.Name = "gunaButtonModify";
            this.gunaButtonModify.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonModify.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonModify.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonModify.OnHoverImage = null;
            this.gunaButtonModify.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonModify.Size = new System.Drawing.Size(257, 31);
            this.gunaButtonModify.TabIndex = 18;
            this.gunaButtonModify.Text = "Modifier";
            this.gunaButtonModify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonModify.Visible = false;
            this.gunaButtonModify.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(135, 129);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(207, 207);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.TabStop = false;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(366, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 64);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "back";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 438);
            this.Controls.Add(this.gunaTrackBar1);
            this.Controls.Add(this.gunaButtonModify);
            this.Controls.Add(this.gunaComboBoxLangue);
            this.Controls.Add(this.gunaComboBoxDiffi);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblTouch);
            this.Controls.Add(this.lblDiffi);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParametres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParametres2";
            this.Load += new System.EventHandler(this.FrmParametres_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDiffi;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTouch;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLang;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVolume;
        private Guna.UI.WinForms.GunaComboBox gunaComboBoxDiffi;
        private Guna.UI.WinForms.GunaComboBox gunaComboBoxLangue;
        private Guna.UI.WinForms.GunaButton gunaButtonModify;
        public Guna.UI.WinForms.GunaTrackBar gunaTrackBar1;
    }
}