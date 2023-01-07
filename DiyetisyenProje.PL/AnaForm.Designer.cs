namespace DiyetisyenProje.PL
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.llKayitOl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.llHakkinda = new System.Windows.Forms.LinkLabel();
            this.chcKullanici = new System.Windows.Forms.RadioButton();
            this.chcAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGiris
            // 
            this.grpGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGiris.BackColor = System.Drawing.Color.Transparent;
            this.grpGiris.Controls.Add(this.llKayitOl);
            this.grpGiris.Controls.Add(this.label2);
            this.grpGiris.Controls.Add(this.txtSifre);
            this.grpGiris.Controls.Add(this.llHakkinda);
            this.grpGiris.Controls.Add(this.chcKullanici);
            this.grpGiris.Controls.Add(this.chcAdmin);
            this.grpGiris.Controls.Add(this.label1);
            this.grpGiris.Controls.Add(this.txtKullaniciAdi);
            this.grpGiris.Controls.Add(this.btnGiris);
            this.grpGiris.Location = new System.Drawing.Point(70, 33);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(435, 476);
            this.grpGiris.TabIndex = 0;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "Giriş ";
            // 
            // llKayitOl
            // 
            this.llKayitOl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.llKayitOl.AutoSize = true;
            this.llKayitOl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llKayitOl.Location = new System.Drawing.Point(177, 393);
            this.llKayitOl.Name = "llKayitOl";
            this.llKayitOl.Size = new System.Drawing.Size(81, 28);
            this.llKayitOl.TabIndex = 9;
            this.llKayitOl.TabStop = true;
            this.llKayitOl.Text = "Kayıt Ol";
            this.llKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llKayitOl_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifre.Location = new System.Drawing.Point(182, 269);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(185, 27);
            this.txtSifre.TabIndex = 2;
            // 
            // llHakkinda
            // 
            this.llHakkinda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.llHakkinda.AutoSize = true;
            this.llHakkinda.Location = new System.Drawing.Point(348, 23);
            this.llHakkinda.Name = "llHakkinda";
            this.llHakkinda.Size = new System.Drawing.Size(64, 20);
            this.llHakkinda.TabIndex = 6;
            this.llHakkinda.TabStop = true;
            this.llHakkinda.Text = "Hakında";
            this.llHakkinda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHakkinda_LinkClicked);
            // 
            // chcKullanici
            // 
            this.chcKullanici.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chcKullanici.AutoSize = true;
            this.chcKullanici.Location = new System.Drawing.Point(174, 92);
            this.chcKullanici.Name = "chcKullanici";
            this.chcKullanici.Size = new System.Drawing.Size(86, 24);
            this.chcKullanici.TabIndex = 4;
            this.chcKullanici.TabStop = true;
            this.chcKullanici.Text = "Kullanıcı";
            this.chcKullanici.UseVisualStyleBackColor = true;
            // 
            // chcAdmin
            // 
            this.chcAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chcAdmin.AutoSize = true;
            this.chcAdmin.Location = new System.Drawing.Point(174, 38);
            this.chcAdmin.Name = "chcAdmin";
            this.chcAdmin.Size = new System.Drawing.Size(74, 24);
            this.chcAdmin.TabIndex = 3;
            this.chcAdmin.TabStop = true;
            this.chcAdmin.Text = "Admin";
            this.chcAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(182, 184);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(185, 27);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGiris.Location = new System.Drawing.Point(155, 336);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(125, 39);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bize Ulaşın";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 635);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpGiris);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpGiris;
        private LinkLabel llKayitOl;
        private Label label2;
        private TextBox txtSifre;
        private LinkLabel llHakkinda;
        private RadioButton chcKullanici;
        private RadioButton chcAdmin;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private Button btnGiris;
        private PictureBox pictureBox1;
        private Label label3;
    }
}