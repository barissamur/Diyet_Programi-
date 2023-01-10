namespace DiyetisyenProje.PL
{
    partial class ListelerimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListelerimForm));
            this.lboxListelerim = new System.Windows.Forms.ListBox();
            this.lboxListeIcerik = new System.Windows.Forms.ListBox();
            this.btnListeSec = new System.Windows.Forms.Button();
            this.btnListeSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeciliListe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxListelerim
            // 
            this.lboxListelerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lboxListelerim.DisplayMember = "ListeAdi";
            this.lboxListelerim.FormattingEnabled = true;
            this.lboxListelerim.ItemHeight = 20;
            this.lboxListelerim.Location = new System.Drawing.Point(43, 65);
            this.lboxListelerim.Name = "lboxListelerim";
            this.lboxListelerim.Size = new System.Drawing.Size(339, 424);
            this.lboxListelerim.TabIndex = 0;
            this.lboxListelerim.SelectedIndexChanged += new System.EventHandler(this.lboxListelerim_SelectedIndexChanged);
            // 
            // lboxListeIcerik
            // 
            this.lboxListeIcerik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lboxListeIcerik.DisplayMember = "Ad";
            this.lboxListeIcerik.FormattingEnabled = true;
            this.lboxListeIcerik.ItemHeight = 20;
            this.lboxListeIcerik.Location = new System.Drawing.Point(533, 65);
            this.lboxListeIcerik.Name = "lboxListeIcerik";
            this.lboxListeIcerik.Size = new System.Drawing.Size(339, 424);
            this.lboxListeIcerik.TabIndex = 1;
            // 
            // btnListeSec
            // 
            this.btnListeSec.BackColor = System.Drawing.Color.LightSalmon;
            this.btnListeSec.Location = new System.Drawing.Point(409, 72);
            this.btnListeSec.Name = "btnListeSec";
            this.btnListeSec.Size = new System.Drawing.Size(101, 38);
            this.btnListeSec.TabIndex = 2;
            this.btnListeSec.Text = "Listeyi Seç";
            this.btnListeSec.UseVisualStyleBackColor = false;
            this.btnListeSec.Click += new System.EventHandler(this.btnListeSec_Click);
            // 
            // btnListeSil
            // 
            this.btnListeSil.BackColor = System.Drawing.Color.LightSalmon;
            this.btnListeSil.Location = new System.Drawing.Point(409, 128);
            this.btnListeSil.Name = "btnListeSil";
            this.btnListeSil.Size = new System.Drawing.Size(101, 38);
            this.btnListeSil.TabIndex = 3;
            this.btnListeSil.Text = "Listeyi Sil";
            this.btnListeSil.UseVisualStyleBackColor = false;
            this.btnListeSil.Click += new System.EventHandler(this.btnListeSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(184, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(672, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Besinler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(409, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seçili Liste";
            // 
            // lblSeciliListe
            // 
            this.lblSeciliListe.BackColor = System.Drawing.Color.Transparent;
            this.lblSeciliListe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeciliListe.Location = new System.Drawing.Point(388, 256);
            this.lblSeciliListe.Name = "lblSeciliListe";
            this.lblSeciliListe.Size = new System.Drawing.Size(139, 33);
            this.lblSeciliListe.TabIndex = 7;
            this.lblSeciliListe.Text = "Seçili Liste Yok";
            this.lblSeciliListe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListelerimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 545);
            this.Controls.Add(this.lblSeciliListe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListeSil);
            this.Controls.Add(this.btnListeSec);
            this.Controls.Add(this.lboxListeIcerik);
            this.Controls.Add(this.lboxListelerim);
            this.Name = "ListelerimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listelerim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lboxListelerim;
        private ListBox lboxListeIcerik;
        private Button btnListeSec;
        private Button btnListeSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSeciliListe;
    }
}