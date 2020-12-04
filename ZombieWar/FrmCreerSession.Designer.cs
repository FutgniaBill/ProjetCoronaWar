namespace ZombieWar
{
    partial class FrmCreerSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreerSession));
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaTextBoxPseudo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBoxSexe = new Guna.UI.WinForms.GunaComboBox();
            this.lblLang = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabelScore = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.gunaButtonSave = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonCancel = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(125, 96);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(207, 207);
            this.bunifuCircleProgressbar1.TabIndex = 1;
            this.bunifuCircleProgressbar1.TabStop = false;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaTextBoxPseudo
            // 
            this.gunaTextBoxPseudo.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxPseudo.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBoxPseudo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaTextBoxPseudo.BorderSize = 3;
            this.gunaTextBoxPseudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxPseudo.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBoxPseudo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaTextBoxPseudo.FocusedForeColor = System.Drawing.Color.White;
            this.gunaTextBoxPseudo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxPseudo.ForeColor = System.Drawing.Color.White;
            this.gunaTextBoxPseudo.Location = new System.Drawing.Point(177, 168);
            this.gunaTextBoxPseudo.Name = "gunaTextBoxPseudo";
            this.gunaTextBoxPseudo.PasswordChar = '\0';
            this.gunaTextBoxPseudo.Radius = 20;
            this.gunaTextBoxPseudo.SelectedText = "";
            this.gunaTextBoxPseudo.Size = new System.Drawing.Size(228, 47);
            this.gunaTextBoxPseudo.TabIndex = 2;
            this.gunaTextBoxPseudo.Visible = false;
            // 
            // gunaComboBoxSexe
            // 
            this.gunaComboBoxSexe.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxSexe.BaseColor = System.Drawing.Color.Transparent;
            this.gunaComboBoxSexe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaComboBoxSexe.DisplayMember = "Débutant";
            this.gunaComboBoxSexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBoxSexe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaComboBoxSexe.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBoxSexe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaComboBoxSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaComboBoxSexe.FormattingEnabled = true;
            this.gunaComboBoxSexe.ItemHeight = 40;
            this.gunaComboBoxSexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.gunaComboBoxSexe.Location = new System.Drawing.Point(177, 242);
            this.gunaComboBoxSexe.Name = "gunaComboBoxSexe";
            this.gunaComboBoxSexe.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.gunaComboBoxSexe.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBoxSexe.Radius = 20;
            this.gunaComboBoxSexe.Size = new System.Drawing.Size(228, 46);
            this.gunaComboBoxSexe.StartIndex = 0;
            this.gunaComboBoxSexe.TabIndex = 19;
            this.gunaComboBoxSexe.Visible = false;
            this.gunaComboBoxSexe.SelectedIndexChanged += new System.EventHandler(this.gunaComboBoxSexe_SelectedIndexChanged);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.White;
            this.lblLang.Location = new System.Drawing.Point(37, 242);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(75, 31);
            this.lblLang.TabIndex = 18;
            this.lblLang.Text = "Sexe";
            this.lblLang.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(37, 168);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 31);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Pseudo";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 96);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(85, 31);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Photo";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 312);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 31);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "Score";
            this.bunifuCustomLabel3.Visible = false;
            // 
            // bunifuCustomLabelScore
            // 
            this.bunifuCustomLabelScore.AutoSize = true;
            this.bunifuCustomLabelScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelScore.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelScore.Location = new System.Drawing.Point(169, 312);
            this.bunifuCustomLabelScore.Name = "bunifuCustomLabelScore";
            this.bunifuCustomLabelScore.Size = new System.Drawing.Size(108, 46);
            this.bunifuCustomLabelScore.TabIndex = 24;
            this.bunifuCustomLabelScore.Text = "0000";
            this.bunifuCustomLabelScore.Visible = false;
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
            this.btnExit.Location = new System.Drawing.Point(360, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 64);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "back";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaButtonSave
            // 
            this.gunaButtonSave.AnimationHoverSpeed = 0.07F;
            this.gunaButtonSave.AnimationSpeed = 0.03F;
            this.gunaButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaButtonSave.BaseColor = System.Drawing.Color.Empty;
            this.gunaButtonSave.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonSave.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButtonSave.ForeColor = System.Drawing.Color.White;
            this.gunaButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonSave.Image")));
            this.gunaButtonSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonSave.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaButtonSave.Location = new System.Drawing.Point(43, 378);
            this.gunaButtonSave.Name = "gunaButtonSave";
            this.gunaButtonSave.OnHoverBaseColor = System.Drawing.Color.Chartreuse;
            this.gunaButtonSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonSave.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonSave.OnHoverImage = null;
            this.gunaButtonSave.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonSave.Size = new System.Drawing.Size(143, 48);
            this.gunaButtonSave.TabIndex = 26;
            this.gunaButtonSave.Text = "Save";
            this.gunaButtonSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonSave.Visible = false;
            this.gunaButtonSave.Click += new System.EventHandler(this.gunaButtonSave_Click);
            // 
            // gunaButtonCancel
            // 
            this.gunaButtonCancel.AnimationHoverSpeed = 0.07F;
            this.gunaButtonCancel.AnimationSpeed = 0.03F;
            this.gunaButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.gunaButtonCancel.BaseColor = System.Drawing.Color.Empty;
            this.gunaButtonCancel.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonCancel.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gunaButtonCancel.ForeColor = System.Drawing.Color.White;
            this.gunaButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonCancel.Image")));
            this.gunaButtonCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaButtonCancel.Location = new System.Drawing.Point(222, 378);
            this.gunaButtonCancel.Name = "gunaButtonCancel";
            this.gunaButtonCancel.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.gunaButtonCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonCancel.OnHoverImage = null;
            this.gunaButtonCancel.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonCancel.Size = new System.Drawing.Size(132, 48);
            this.gunaButtonCancel.TabIndex = 27;
            this.gunaButtonCancel.Text = "Cancel";
            this.gunaButtonCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonCancel.Visible = false;
            this.gunaButtonCancel.Click += new System.EventHandler(this.gunaButtonCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmCreerSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaButtonCancel);
            this.Controls.Add(this.gunaButtonSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bunifuCustomLabelScore);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.gunaComboBoxSexe);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.gunaTextBoxPseudo);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreerSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreerSession";
            this.Load += new System.EventHandler(this.FrmCreerSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxPseudo;
        private Guna.UI.WinForms.GunaComboBox gunaComboBoxSexe;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLang;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelScore;
        private System.Windows.Forms.Button btnExit;
        private Guna.UI.WinForms.GunaButton gunaButtonSave;
        private Guna.UI.WinForms.GunaButton gunaButtonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}