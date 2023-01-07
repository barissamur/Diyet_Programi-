namespace DiyetisyenProje.PL
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tcontrolAdmin = new System.Windows.Forms.TabControl();
            this.tpageBesinler = new System.Windows.Forms.TabPage();
            this.cboKategoriler = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chcKalori = new System.Windows.Forms.CheckBox();
            this.chcBesinAd = new System.Windows.Forms.CheckBox();
            this.chcId = new System.Windows.Forms.CheckBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAdminAdSoyad = new System.Windows.Forms.Label();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBesinler = new System.Windows.Forms.DataGridView();
            this.tpageKullanicilar = new System.Windows.Forms.TabPage();
            this.cboSirala = new System.Windows.Forms.ComboBox();
            this.cboCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtKalcaCevresi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBelCevresi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoyunCevresi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKulGuncelle = new System.Windows.Forms.Button();
            this.btnKulSil = new System.Windows.Forms.Button();
            this.txtKullaniciSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKullaniciId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.tcontrolAdmin.SuspendLayout();
            this.tpageBesinler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).BeginInit();
            this.tpageKullanicilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // tcontrolAdmin
            // 
            this.tcontrolAdmin.Controls.Add(this.tpageBesinler);
            this.tcontrolAdmin.Controls.Add(this.tpageKullanicilar);
            this.tcontrolAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcontrolAdmin.Location = new System.Drawing.Point(0, 0);
            this.tcontrolAdmin.Name = "tcontrolAdmin";
            this.tcontrolAdmin.SelectedIndex = 0;
            this.tcontrolAdmin.Size = new System.Drawing.Size(1464, 721);
            this.tcontrolAdmin.TabIndex = 0;
            // 
            // tpageBesinler
            // 
            this.tpageBesinler.Controls.Add(this.cboKategoriler);
            this.tpageBesinler.Controls.Add(this.label14);
            this.tpageBesinler.Controls.Add(this.chcKalori);
            this.tpageBesinler.Controls.Add(this.chcBesinAd);
            this.tpageBesinler.Controls.Add(this.chcId);
            this.tpageBesinler.Controls.Add(this.btnAra);
            this.tpageBesinler.Controls.Add(this.btnGuncelle);
            this.tpageBesinler.Controls.Add(this.btnSil);
            this.tpageBesinler.Controls.Add(this.btnEkle);
            this.tpageBesinler.Controls.Add(this.lblAdminAdSoyad);
            this.tpageBesinler.Controls.Add(this.txtKalori);
            this.tpageBesinler.Controls.Add(this.label4);
            this.tpageBesinler.Controls.Add(this.txtAd);
            this.tpageBesinler.Controls.Add(this.label5);
            this.tpageBesinler.Controls.Add(this.txtId);
            this.tpageBesinler.Controls.Add(this.label3);
            this.tpageBesinler.Controls.Add(this.label1);
            this.tpageBesinler.Controls.Add(this.dgvBesinler);
            this.tpageBesinler.Location = new System.Drawing.Point(4, 29);
            this.tpageBesinler.Name = "tpageBesinler";
            this.tpageBesinler.Padding = new System.Windows.Forms.Padding(3);
            this.tpageBesinler.Size = new System.Drawing.Size(1456, 688);
            this.tpageBesinler.TabIndex = 0;
            this.tpageBesinler.Text = "Besinler";
            this.tpageBesinler.UseVisualStyleBackColor = true;
            // 
            // cboKategoriler
            // 
            this.cboKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategoriler.FormattingEnabled = true;
            this.cboKategoriler.Location = new System.Drawing.Point(997, 81);
            this.cboKategoriler.Name = "cboKategoriler";
            this.cboKategoriler.Size = new System.Drawing.Size(237, 28);
            this.cboKategoriler.TabIndex = 19;
            this.cboKategoriler.SelectedIndexChanged += new System.EventHandler(this.cboKategoriler_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(918, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Kategori :";
            // 
            // chcKalori
            // 
            this.chcKalori.AutoSize = true;
            this.chcKalori.Location = new System.Drawing.Point(824, 202);
            this.chcKalori.Name = "chcKalori";
            this.chcKalori.Size = new System.Drawing.Size(120, 24);
            this.chcKalori.TabIndex = 17;
            this.chcKalori.Text = "Kaloriye göre";
            this.chcKalori.UseVisualStyleBackColor = true;
            // 
            // chcBesinAd
            // 
            this.chcBesinAd.AutoSize = true;
            this.chcBesinAd.Location = new System.Drawing.Point(824, 172);
            this.chcBesinAd.Name = "chcBesinAd";
            this.chcBesinAd.Size = new System.Drawing.Size(144, 24);
            this.chcBesinAd.TabIndex = 16;
            this.chcBesinAd.Text = "Besin Adına göre";
            this.chcBesinAd.UseVisualStyleBackColor = true;
            // 
            // chcId
            // 
            this.chcId.AutoSize = true;
            this.chcId.Location = new System.Drawing.Point(824, 142);
            this.chcId.Name = "chcId";
            this.chcId.Size = new System.Drawing.Size(103, 24);
            this.chcId.TabIndex = 15;
            this.chcId.Text = "ID\' ye göre";
            this.chcId.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.DimGray;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.ForeColor = System.Drawing.Color.Black;
            this.btnAra.Location = new System.Drawing.Point(974, 147);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(164, 67);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(472, 165);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(128, 37);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(625, 165);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 37);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(319, 162);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 37);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblAdminAdSoyad
            // 
            this.lblAdminAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdminAdSoyad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminAdSoyad.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminAdSoyad.Location = new System.Drawing.Point(3, 3);
            this.lblAdminAdSoyad.Name = "lblAdminAdSoyad";
            this.lblAdminAdSoyad.Size = new System.Drawing.Size(1450, 55);
            this.lblAdminAdSoyad.TabIndex = 10;
            this.lblAdminAdSoyad.Text = "-";
            this.lblAdminAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(752, 78);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(125, 27);
            this.txtKalori.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalori :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(524, 78);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 27);
            this.txtAd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Besin Adı :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(260, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 27);
            this.txtId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Besinler";
            // 
            // dgvBesinler
            // 
            this.dgvBesinler.AllowUserToAddRows = false;
            this.dgvBesinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBesinler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBesinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBesinler.Location = new System.Drawing.Point(3, 239);
            this.dgvBesinler.MultiSelect = false;
            this.dgvBesinler.Name = "dgvBesinler";
            this.dgvBesinler.ReadOnly = true;
            this.dgvBesinler.RowHeadersVisible = false;
            this.dgvBesinler.RowHeadersWidth = 51;
            this.dgvBesinler.RowTemplate.Height = 29;
            this.dgvBesinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinler.Size = new System.Drawing.Size(1450, 446);
            this.dgvBesinler.TabIndex = 0;
            this.dgvBesinler.SelectionChanged += new System.EventHandler(this.dgvBesinler_SelectionChanged);
            // 
            // tpageKullanicilar
            // 
            this.tpageKullanicilar.Controls.Add(this.cboSirala);
            this.tpageKullanicilar.Controls.Add(this.cboCinsiyet);
            this.tpageKullanicilar.Controls.Add(this.dtpDogumTarihi);
            this.tpageKullanicilar.Controls.Add(this.txtKalcaCevresi);
            this.tpageKullanicilar.Controls.Add(this.label15);
            this.tpageKullanicilar.Controls.Add(this.txtBelCevresi);
            this.tpageKullanicilar.Controls.Add(this.label16);
            this.tpageKullanicilar.Controls.Add(this.txtBoyunCevresi);
            this.tpageKullanicilar.Controls.Add(this.label17);
            this.tpageKullanicilar.Controls.Add(this.txtBoy);
            this.tpageKullanicilar.Controls.Add(this.label10);
            this.tpageKullanicilar.Controls.Add(this.label11);
            this.tpageKullanicilar.Controls.Add(this.txtKilo);
            this.tpageKullanicilar.Controls.Add(this.label12);
            this.tpageKullanicilar.Controls.Add(this.label13);
            this.tpageKullanicilar.Controls.Add(this.txtKulAdi);
            this.tpageKullanicilar.Controls.Add(this.label9);
            this.tpageKullanicilar.Controls.Add(this.btnKulGuncelle);
            this.tpageKullanicilar.Controls.Add(this.btnKulSil);
            this.tpageKullanicilar.Controls.Add(this.txtKullaniciSoyad);
            this.tpageKullanicilar.Controls.Add(this.label6);
            this.tpageKullanicilar.Controls.Add(this.txtKullaniciAd);
            this.tpageKullanicilar.Controls.Add(this.label7);
            this.tpageKullanicilar.Controls.Add(this.txtKullaniciId);
            this.tpageKullanicilar.Controls.Add(this.label8);
            this.tpageKullanicilar.Controls.Add(this.label2);
            this.tpageKullanicilar.Controls.Add(this.dgvKullanicilar);
            this.tpageKullanicilar.Location = new System.Drawing.Point(4, 29);
            this.tpageKullanicilar.Name = "tpageKullanicilar";
            this.tpageKullanicilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpageKullanicilar.Size = new System.Drawing.Size(1456, 688);
            this.tpageKullanicilar.TabIndex = 1;
            this.tpageKullanicilar.Text = "Kullanıcılar";
            this.tpageKullanicilar.UseVisualStyleBackColor = true;
            // 
            // cboSirala
            // 
            this.cboSirala.FormattingEnabled = true;
            this.cboSirala.Location = new System.Drawing.Point(655, 239);
            this.cboSirala.Name = "cboSirala";
            this.cboSirala.Size = new System.Drawing.Size(322, 28);
            this.cboSirala.TabIndex = 49;
            this.cboSirala.SelectedIndexChanged += new System.EventHandler(this.cboSirala_SelectedIndexChanged);
            // 
            // cboCinsiyet
            // 
            this.cboCinsiyet.FormattingEnabled = true;
            this.cboCinsiyet.Location = new System.Drawing.Point(498, 21);
            this.cboCinsiyet.Name = "cboCinsiyet";
            this.cboCinsiyet.Size = new System.Drawing.Size(151, 28);
            this.cboCinsiyet.TabIndex = 48;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(498, 116);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(250, 27);
            this.dtpDogumTarihi.TabIndex = 47;
            // 
            // txtKalcaCevresi
            // 
            this.txtKalcaCevresi.Location = new System.Drawing.Point(892, 110);
            this.txtKalcaCevresi.Name = "txtKalcaCevresi";
            this.txtKalcaCevresi.Size = new System.Drawing.Size(125, 27);
            this.txtKalcaCevresi.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(783, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Kalça Çevresi :";
            // 
            // txtBelCevresi
            // 
            this.txtBelCevresi.Location = new System.Drawing.Point(892, 66);
            this.txtBelCevresi.Name = "txtBelCevresi";
            this.txtBelCevresi.Size = new System.Drawing.Size(125, 27);
            this.txtBelCevresi.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(798, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Bel Çevresi :";
            // 
            // txtBoyunCevresi
            // 
            this.txtBoyunCevresi.Location = new System.Drawing.Point(892, 22);
            this.txtBoyunCevresi.Name = "txtBoyunCevresi";
            this.txtBoyunCevresi.Size = new System.Drawing.Size(125, 27);
            this.txtBoyunCevresi.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(778, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 20);
            this.label17.TabIndex = 41;
            this.label17.Text = "Boyun Çevresi :";
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(498, 163);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(125, 27);
            this.txtBoy.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Boy :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Doğum Tarihi :";
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(498, 69);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(125, 27);
            this.txtKilo.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Kilo :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(425, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cinsiyet :";
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(180, 157);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(125, 27);
            this.txtKulAdi.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Kullanici Adı :";
            // 
            // btnKulGuncelle
            // 
            this.btnKulGuncelle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKulGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKulGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnKulGuncelle.Location = new System.Drawing.Point(259, 231);
            this.btnKulGuncelle.Name = "btnKulGuncelle";
            this.btnKulGuncelle.Size = new System.Drawing.Size(128, 37);
            this.btnKulGuncelle.TabIndex = 26;
            this.btnKulGuncelle.Text = "GÜNCELLE";
            this.btnKulGuncelle.UseVisualStyleBackColor = false;
            this.btnKulGuncelle.Click += new System.EventHandler(this.btnKulGuncelle_Click);
            // 
            // btnKulSil
            // 
            this.btnKulSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnKulSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKulSil.ForeColor = System.Drawing.Color.Black;
            this.btnKulSil.Location = new System.Drawing.Point(412, 231);
            this.btnKulSil.Name = "btnKulSil";
            this.btnKulSil.Size = new System.Drawing.Size(128, 37);
            this.btnKulSil.TabIndex = 25;
            this.btnKulSil.Text = "SİL";
            this.btnKulSil.UseVisualStyleBackColor = false;
            this.btnKulSil.Click += new System.EventHandler(this.btnKulSil_Click);
            // 
            // txtKullaniciSoyad
            // 
            this.txtKullaniciSoyad.Location = new System.Drawing.Point(180, 112);
            this.txtKullaniciSoyad.Name = "txtKullaniciSoyad";
            this.txtKullaniciSoyad.Size = new System.Drawing.Size(125, 27);
            this.txtKullaniciSoyad.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Soyad :";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(180, 67);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(125, 27);
            this.txtKullaniciAd.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ad :";
            // 
            // txtKullaniciId
            // 
            this.txtKullaniciId.Location = new System.Drawing.Point(180, 22);
            this.txtKullaniciId.Name = "txtKullaniciId";
            this.txtKullaniciId.Size = new System.Drawing.Size(125, 27);
            this.txtKullaniciId.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcılar";
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKullanicilar.Location = new System.Drawing.Point(3, 305);
            this.dgvKullanicilar.MultiSelect = false;
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.RowHeadersVisible = false;
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 29;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(1450, 380);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.SelectionChanged += new System.EventHandler(this.dgvKullanicilar_SelectionChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 721);
            this.Controls.Add(this.tcontrolAdmin);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.tcontrolAdmin.ResumeLayout(false);
            this.tpageBesinler.ResumeLayout(false);
            this.tpageBesinler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).EndInit();
            this.tpageKullanicilar.ResumeLayout(false);
            this.tpageKullanicilar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcontrolAdmin;
        private TabPage tpageBesinler;
        private Label label1;
        private DataGridView dgvBesinler;
        private TabPage tpageKullanicilar;
        private Label label2;
        private DataGridView dgvKullanicilar;
        private TextBox txtId;
        private Label label3;
        private Label lblAdminAdSoyad;
        private TextBox txtKalori;
        private Label label4;
        private TextBox txtAd;
        private Label label5;
        private Button btnAra;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private CheckBox chcKalori;
        private CheckBox chcBesinAd;
        private CheckBox chcId;
        private Button btnKulGuncelle;
        private Button btnKulSil;
        private TextBox txtKullaniciSoyad;
        private Label label6;
        private TextBox txtKullaniciAd;
        private Label label7;
        private TextBox txtKullaniciId;
        private Label label8;
        private TextBox txtKalcaCevresi;
        private Label label15;
        private TextBox txtBelCevresi;
        private Label label16;
        private TextBox txtBoyunCevresi;
        private Label label17;
        private TextBox txtBoy;
        private Label label10;
        private Label label11;
        private TextBox txtKilo;
        private Label label12;
        private Label label13;
        private TextBox txtKulAdi;
        private Label label9;
        private DateTimePicker dtpDogumTarihi;
        private ComboBox cboCinsiyet;
        private ComboBox cboSirala;
        private ComboBox cboKategoriler;
        private Label label14;
    }
}