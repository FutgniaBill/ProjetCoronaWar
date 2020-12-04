namespace ZombieWar
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnParametre = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnNouvPartie = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(449, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
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
            this.btnExit.Location = new System.Drawing.Point(372, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sortie";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSession
            // 
            this.btnSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.ForeColor = System.Drawing.Color.White;
            this.btnSession.Image = ((System.Drawing.Image)(resources.GetObject("btnSession.Image")));
            this.btnSession.Location = new System.Drawing.Point(141, 375);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(166, 64);
            this.btnSession.TabIndex = 4;
            this.btnSession.Text = "Session";
            this.btnSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSession.UseVisualStyleBackColor = false;
            this.btnSession.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParametre
            // 
            this.btnParametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.btnParametre.FlatAppearance.BorderSize = 0;
            this.btnParametre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametre.ForeColor = System.Drawing.Color.White;
            this.btnParametre.Image = ((System.Drawing.Image)(resources.GetObject("btnParametre.Image")));
            this.btnParametre.Location = new System.Drawing.Point(143, 288);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(166, 64);
            this.btnParametre.TabIndex = 3;
            this.btnParametre.Text = "Parametres";
            this.btnParametre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParametre.UseVisualStyleBackColor = false;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Image = ((System.Drawing.Image)(resources.GetObject("btnResume.Image")));
            this.btnResume.Location = new System.Drawing.Point(141, 205);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(166, 64);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Continuer";
            this.btnResume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnNouvPartie
            // 
            this.btnNouvPartie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.btnNouvPartie.FlatAppearance.BorderSize = 0;
            this.btnNouvPartie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNouvPartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvPartie.ForeColor = System.Drawing.Color.White;
            this.btnNouvPartie.Image = ((System.Drawing.Image)(resources.GetObject("btnNouvPartie.Image")));
            this.btnNouvPartie.Location = new System.Drawing.Point(143, 122);
            this.btnNouvPartie.Name = "btnNouvPartie";
            this.btnNouvPartie.Size = new System.Drawing.Size(166, 64);
            this.btnNouvPartie.TabIndex = 1;
            this.btnNouvPartie.Text = "Nouvelle partie";
            this.btnNouvPartie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouvPartie.UseVisualStyleBackColor = false;
            this.btnNouvPartie.Click += new System.EventHandler(this.btnNouvPartie_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(449, 477);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.btnParametre);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnNouvPartie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouvPartie;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnParametre;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnExit;
    }
}