namespace ZombieWar
{
    partial class FrmSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSession));
            this.gunaButtonCreer = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonModif = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonVue = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonSupprimer = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.Search = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pseudo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Sexe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scrore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaButtonCreer
            // 
            this.gunaButtonCreer.AnimationHoverSpeed = 0.07F;
            this.gunaButtonCreer.AnimationSpeed = 0.03F;
            this.gunaButtonCreer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaButtonCreer.BaseColor = System.Drawing.Color.Empty;
            this.gunaButtonCreer.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonCreer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonCreer.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonCreer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButtonCreer.ForeColor = System.Drawing.Color.White;
            this.gunaButtonCreer.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonCreer.Image")));
            this.gunaButtonCreer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonCreer.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonCreer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaButtonCreer.Location = new System.Drawing.Point(12, 321);
            this.gunaButtonCreer.Name = "gunaButtonCreer";
            this.gunaButtonCreer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonCreer.OnHoverBorderColor = System.Drawing.Color.AntiqueWhite;
            this.gunaButtonCreer.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonCreer.OnHoverImage = null;
            this.gunaButtonCreer.OnPressedColor = System.Drawing.Color.Gold;
            this.gunaButtonCreer.Size = new System.Drawing.Size(139, 31);
            this.gunaButtonCreer.TabIndex = 19;
            this.gunaButtonCreer.Text = "Creer";
            this.gunaButtonCreer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonCreer.Visible = false;
            this.gunaButtonCreer.Click += new System.EventHandler(this.gunaButtonCreer_Click);
            // 
            // gunaButtonModif
            // 
            this.gunaButtonModif.AnimationHoverSpeed = 0.07F;
            this.gunaButtonModif.AnimationSpeed = 0.03F;
            this.gunaButtonModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaButtonModif.BaseColor = System.Drawing.Color.Empty;
            this.gunaButtonModif.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonModif.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonModif.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonModif.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButtonModif.ForeColor = System.Drawing.Color.White;
            this.gunaButtonModif.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonModif.Image")));
            this.gunaButtonModif.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonModif.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonModif.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaButtonModif.Location = new System.Drawing.Point(282, 321);
            this.gunaButtonModif.Name = "gunaButtonModif";
            this.gunaButtonModif.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonModif.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonModif.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonModif.OnHoverImage = null;
            this.gunaButtonModif.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonModif.Size = new System.Drawing.Size(139, 31);
            this.gunaButtonModif.TabIndex = 20;
            this.gunaButtonModif.Text = "Modifier";
            this.gunaButtonModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonModif.Visible = false;
            this.gunaButtonModif.Click += new System.EventHandler(this.gunaButtonModif_Click);
            // 
            // gunaButtonVue
            // 
            this.gunaButtonVue.AnimationHoverSpeed = 0.07F;
            this.gunaButtonVue.AnimationSpeed = 0.03F;
            this.gunaButtonVue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaButtonVue.BaseColor = System.Drawing.Color.Empty;
            this.gunaButtonVue.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonVue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonVue.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonVue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButtonVue.ForeColor = System.Drawing.Color.White;
            this.gunaButtonVue.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonVue.Image")));
            this.gunaButtonVue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonVue.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonVue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaButtonVue.Location = new System.Drawing.Point(282, 387);
            this.gunaButtonVue.Name = "gunaButtonVue";
            this.gunaButtonVue.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonVue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonVue.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonVue.OnHoverImage = null;
            this.gunaButtonVue.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonVue.Size = new System.Drawing.Size(139, 31);
            this.gunaButtonVue.TabIndex = 21;
            this.gunaButtonVue.Text = "Vue";
            this.gunaButtonVue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonVue.Visible = false;
            this.gunaButtonVue.Click += new System.EventHandler(this.gunaButtonVue_Click);
            // 
            // gunaButtonSupprimer
            // 
            this.gunaButtonSupprimer.AnimationHoverSpeed = 0.07F;
            this.gunaButtonSupprimer.AnimationSpeed = 0.03F;
            this.gunaButtonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaButtonSupprimer.BaseColor = System.Drawing.Color.Empty;
            this.gunaButtonSupprimer.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonSupprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonSupprimer.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonSupprimer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButtonSupprimer.ForeColor = System.Drawing.Color.White;
            this.gunaButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonSupprimer.Image")));
            this.gunaButtonSupprimer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonSupprimer.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonSupprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaButtonSupprimer.Location = new System.Drawing.Point(12, 387);
            this.gunaButtonSupprimer.Name = "gunaButtonSupprimer";
            this.gunaButtonSupprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonSupprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonSupprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonSupprimer.OnHoverImage = null;
            this.gunaButtonSupprimer.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonSupprimer.Size = new System.Drawing.Size(139, 31);
            this.gunaButtonSupprimer.TabIndex = 23;
            this.gunaButtonSupprimer.Text = "Supprimer";
            this.gunaButtonSupprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonSupprimer.Visible = false;
            this.gunaButtonSupprimer.Click += new System.EventHandler(this.gunaButtonSupprimer_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.BorderSize = 3;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.Color.White;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.White;
            this.gunaTextBox1.Location = new System.Drawing.Point(12, 257);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 20;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(409, 47);
            this.gunaTextBox1.TabIndex = 0;
            this.gunaTextBox1.Visible = false;
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.Search.Location = new System.Drawing.Point(12, 241);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 25;
            this.Search.Text = "Search";
            this.Search.Visible = false;
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
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(105, 124);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(226, 226);
            this.bunifuCircleProgressbar1.TabIndex = 26;
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
            this.btnExit.Location = new System.Drawing.Point(179, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 64);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "back";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pseudo2,
            this.Photo1,
            this.Sexe1,
            this.Scrore});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(433, 238);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Pseudo2
            // 
            this.Pseudo2.DataPropertyName = "Pseudo";
            this.Pseudo2.HeaderText = "Pseudo";
            this.Pseudo2.Name = "Pseudo2";
            // 
            // Photo1
            // 
            this.Photo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Photo1.DataPropertyName = "Photo";
            this.Photo1.HeaderText = "Photo";
            this.Photo1.Name = "Photo1";
            // 
            // Sexe1
            // 
            this.Sexe1.DataPropertyName = "Sexe";
            this.Sexe1.HeaderText = "Sexe";
            this.Sexe1.Name = "Sexe1";
            // 
            // Scrore
            // 
            this.Scrore.DataPropertyName = "Score";
            this.Scrore.HeaderText = "Score";
            this.Scrore.Name = "Scrore";
            // 
            // FrmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaButtonSupprimer);
            this.Controls.Add(this.gunaButtonVue);
            this.Controls.Add(this.gunaButtonModif);
            this.Controls.Add(this.gunaButtonCreer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSession";
            this.Load += new System.EventHandler(this.FrmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButtonCreer;
        private Guna.UI.WinForms.GunaButton gunaButtonModif;
        private Guna.UI.WinForms.GunaButton gunaButtonVue;
        private Guna.UI.WinForms.GunaButton gunaButtonSupprimer;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Label Search;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseudo2;
        private System.Windows.Forms.DataGridViewImageColumn Photo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scrore;
    }
}