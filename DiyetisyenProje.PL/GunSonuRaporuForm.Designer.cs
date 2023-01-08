namespace DiyetisyenProje.PL
{
    partial class GunSonuRaporuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunSonuRaporuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarihSec = new System.Windows.Forms.DateTimePicker();
            this.lboxGecmisListeler = new System.Windows.Forms.ListBox();
            this.lboxListeIcerik = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGunlukTopKalori = new System.Windows.Forms.Label();
            this.lblKaloriler = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(399, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih Seçin";
            // 
            // dtpTarihSec
            // 
            this.dtpTarihSec.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dtpTarihSec.Location = new System.Drawing.Point(327, 62);
            this.dtpTarihSec.Name = "dtpTarihSec";
            this.dtpTarihSec.Size = new System.Drawing.Size(250, 27);
            this.dtpTarihSec.TabIndex = 1;
            this.dtpTarihSec.ValueChanged += new System.EventHandler(this.dtpTarihSec_ValueChanged);
            // 
            // lboxGecmisListeler
            // 
            this.lboxGecmisListeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lboxGecmisListeler.FormattingEnabled = true;
            this.lboxGecmisListeler.ItemHeight = 20;
            this.lboxGecmisListeler.Location = new System.Drawing.Point(12, 191);
            this.lboxGecmisListeler.Name = "lboxGecmisListeler";
            this.lboxGecmisListeler.Size = new System.Drawing.Size(138, 424);
            this.lboxGecmisListeler.TabIndex = 2;
            this.lboxGecmisListeler.SelectedIndexChanged += new System.EventHandler(this.lboxGecmisListeler_SelectedIndexChanged);
            // 
            // lboxListeIcerik
            // 
            this.lboxListeIcerik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lboxListeIcerik.FormattingEnabled = true;
            this.lboxListeIcerik.ItemHeight = 20;
            this.lboxListeIcerik.Location = new System.Drawing.Point(655, 191);
            this.lboxListeIcerik.Name = "lboxListeIcerik";
            this.lboxListeIcerik.Size = new System.Drawing.Size(368, 424);
            this.lboxListeIcerik.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(91, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geçmiş Listeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(783, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste İçeriği";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(350, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Günlük Toplam Kalori";
            // 
            // lblGunlukTopKalori
            // 
            this.lblGunlukTopKalori.BackColor = System.Drawing.Color.Transparent;
            this.lblGunlukTopKalori.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGunlukTopKalori.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGunlukTopKalori.Location = new System.Drawing.Point(321, 203);
            this.lblGunlukTopKalori.Name = "lblGunlukTopKalori";
            this.lblGunlukTopKalori.Size = new System.Drawing.Size(263, 25);
            this.lblGunlukTopKalori.TabIndex = 7;
            this.lblGunlukTopKalori.Text = "0";
            this.lblGunlukTopKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKaloriler
            // 
            this.lblKaloriler.AutoSize = true;
            this.lblKaloriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKaloriler.Location = new System.Drawing.Point(156, 191);
            this.lblKaloriler.Name = "lblKaloriler";
            this.lblKaloriler.Size = new System.Drawing.Size(0, 20);
            this.lblKaloriler.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // GunSonuRaporuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 627);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKaloriler);
            this.Controls.Add(this.lblGunlukTopKalori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboxListeIcerik);
            this.Controls.Add(this.lboxGecmisListeler);
            this.Controls.Add(this.dtpTarihSec);
            this.Controls.Add(this.label1);
            this.Name = "GunSonuRaporuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GunSonuRaporuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dtpTarihSec;
        private ListBox lboxGecmisListeler;
        private ListBox lboxListeIcerik;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblGunlukTopKalori;
        private ListBox lboxKaloriler;
        private Label lblKaloriler;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}