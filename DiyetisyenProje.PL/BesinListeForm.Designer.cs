namespace DiyetisyenProje.PL
{
    partial class BesinListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BesinListeForm));
            this.lboxBesinler = new System.Windows.Forms.ListBox();
            this.lboxSecilenler = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lblSeciliBesin = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblSecilBesinSil = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtListeAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBesinAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxKategoriler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lboxBesinler
            // 
            this.lboxBesinler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lboxBesinler.DisplayMember = "Ad, Kalori";
            this.lboxBesinler.FormattingEnabled = true;
            this.lboxBesinler.ItemHeight = 20;
            this.lboxBesinler.Location = new System.Drawing.Point(0, 180);
            this.lboxBesinler.Name = "lboxBesinler";
            this.lboxBesinler.Size = new System.Drawing.Size(334, 424);
            this.lboxBesinler.TabIndex = 0;
            this.lboxBesinler.SelectedIndexChanged += new System.EventHandler(this.lboxBesinler_SelectedIndexChanged);
            // 
            // lboxSecilenler
            // 
            this.lboxSecilenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lboxSecilenler.DisplayMember = "Besin";
            this.lboxSecilenler.FormattingEnabled = true;
            this.lboxSecilenler.ItemHeight = 20;
            this.lboxSecilenler.Location = new System.Drawing.Point(548, 180);
            this.lboxSecilenler.Name = "lboxSecilenler";
            this.lboxSecilenler.Size = new System.Drawing.Size(328, 424);
            this.lboxSecilenler.TabIndex = 1;
            this.lboxSecilenler.SelectedIndexChanged += new System.EventHandler(this.lboxSecilenler_SelectedIndexChanged);
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.Salmon;
            this.btnAktar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAktar.Location = new System.Drawing.Point(373, 65);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(131, 68);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = ">>";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lblSeciliBesin
            // 
            this.lblSeciliBesin.AutoSize = true;
            this.lblSeciliBesin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSeciliBesin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeciliBesin.Location = new System.Drawing.Point(12, 9);
            this.lblSeciliBesin.Name = "lblSeciliBesin";
            this.lblSeciliBesin.Size = new System.Drawing.Size(20, 28);
            this.lblSeciliBesin.TabIndex = 3;
            this.lblSeciliBesin.Text = "-";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Salmon;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(373, 175);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 68);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "<<";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblSecilBesinSil
            // 
            this.lblSecilBesinSil.AutoSize = true;
            this.lblSecilBesinSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSecilBesinSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecilBesinSil.Location = new System.Drawing.Point(548, 9);
            this.lblSecilBesinSil.Name = "lblSecilBesinSil";
            this.lblSecilBesinSil.Size = new System.Drawing.Size(20, 28);
            this.lblSecilBesinSil.TabIndex = 5;
            this.lblSecilBesinSil.Text = "-";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Salmon;
            this.btnKaydet.Location = new System.Drawing.Point(373, 316);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 61);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtListeAd
            // 
            this.txtListeAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtListeAd.Location = new System.Drawing.Point(645, 57);
            this.txtListeAd.Name = "txtListeAd";
            this.txtListeAd.Size = new System.Drawing.Size(219, 27);
            this.txtListeAd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(548, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liste Adı :";
            // 
            // txtBesinAra
            // 
            this.txtBesinAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBesinAra.Location = new System.Drawing.Point(83, 147);
            this.txtBesinAra.Name = "txtBesinAra";
            this.txtBesinAra.Size = new System.Drawing.Size(169, 27);
            this.txtBesinAra.TabIndex = 9;
            this.txtBesinAra.TextChanged += new System.EventHandler(this.txtBesinAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Besin Ara";
            // 
            // cboxKategoriler
            // 
            this.cboxKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboxKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKategoriler.FormattingEnabled = true;
            this.cboxKategoriler.Location = new System.Drawing.Point(29, 65);
            this.cboxKategoriler.Name = "cboxKategoriler";
            this.cboxKategoriler.Size = new System.Drawing.Size(277, 28);
            this.cboxKategoriler.TabIndex = 11;
            this.cboxKategoriler.SelectedIndexChanged += new System.EventHandler(this.cboxKategoriler_SelectedIndexChanged);
            // 
            // BesinListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 630);
            this.Controls.Add(this.cboxKategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBesinAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListeAd);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblSecilBesinSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblSeciliBesin);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lboxSecilenler);
            this.Controls.Add(this.lboxBesinler);
            this.Name = "BesinListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lboxBesinler;
        private ListBox lboxSecilenler;
        private Button button1;
        private Button btnAktar;
        private Label lblSeciliBesin;
        private Button btnSil;
        private Label lblSecilBesinSil;
        private Button btnKaydet;
        private TextBox txtListeAd;
        private Label label1;
        private TextBox txtBesinAra;
        private Label label2;
        private ComboBox cboxKategoriler;
    }
}