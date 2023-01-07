namespace DiyetisyenProje.PL
{
    partial class YemekCesidiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YemekCesidiForm));
            this.dgvEnCokBesin = new System.Windows.Forms.DataGridView();
            this.lblEnCokBesin = new System.Windows.Forms.Label();
            this.lblIkinciUrun = new System.Windows.Forms.Label();
            this.lblUcuncuUrun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokBesin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnCokBesin
            // 
            this.dgvEnCokBesin.AllowUserToAddRows = false;
            this.dgvEnCokBesin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnCokBesin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnCokBesin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnCokBesin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEnCokBesin.Location = new System.Drawing.Point(0, 234);
            this.dgvEnCokBesin.MultiSelect = false;
            this.dgvEnCokBesin.Name = "dgvEnCokBesin";
            this.dgvEnCokBesin.ReadOnly = true;
            this.dgvEnCokBesin.RowHeadersVisible = false;
            this.dgvEnCokBesin.RowHeadersWidth = 51;
            this.dgvEnCokBesin.RowTemplate.Height = 29;
            this.dgvEnCokBesin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnCokBesin.Size = new System.Drawing.Size(1324, 383);
            this.dgvEnCokBesin.TabIndex = 0;
            // 
            // lblEnCokBesin
            // 
            this.lblEnCokBesin.AutoSize = true;
            this.lblEnCokBesin.BackColor = System.Drawing.Color.Transparent;
            this.lblEnCokBesin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnCokBesin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEnCokBesin.Location = new System.Drawing.Point(441, 31);
            this.lblEnCokBesin.Name = "lblEnCokBesin";
            this.lblEnCokBesin.Size = new System.Drawing.Size(442, 25);
            this.lblEnCokBesin.TabIndex = 1;
            this.lblEnCokBesin.Text = "Kullanıcılar Arasında En Çok Tercih Edilen Ürün : ";
            // 
            // lblIkinciUrun
            // 
            this.lblIkinciUrun.AutoSize = true;
            this.lblIkinciUrun.BackColor = System.Drawing.Color.Transparent;
            this.lblIkinciUrun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIkinciUrun.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIkinciUrun.Location = new System.Drawing.Point(415, 73);
            this.lblIkinciUrun.Name = "lblIkinciUrun";
            this.lblIkinciUrun.Size = new System.Drawing.Size(495, 25);
            this.lblIkinciUrun.TabIndex = 2;
            this.lblIkinciUrun.Text = "Kullanıcılar Arasında En Çok Tercih Edilen İkinci Ürün : ";
            // 
            // lblUcuncuUrun
            // 
            this.lblUcuncuUrun.AutoSize = true;
            this.lblUcuncuUrun.BackColor = System.Drawing.Color.Transparent;
            this.lblUcuncuUrun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUcuncuUrun.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUcuncuUrun.Location = new System.Drawing.Point(405, 120);
            this.lblUcuncuUrun.Name = "lblUcuncuUrun";
            this.lblUcuncuUrun.Size = new System.Drawing.Size(515, 25);
            this.lblUcuncuUrun.TabIndex = 3;
            this.lblUcuncuUrun.Text = "Kullanıcılar Arasında En Çok Tercih Edilen Üçüncü Ürün : ";
            // 
            // YemekCesidiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 617);
            this.Controls.Add(this.lblUcuncuUrun);
            this.Controls.Add(this.lblIkinciUrun);
            this.Controls.Add(this.lblEnCokBesin);
            this.Controls.Add(this.dgvEnCokBesin);
            this.Name = "YemekCesidiForm";
            this.Text = "YemekCesidiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokBesin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvEnCokBesin;
        private Label lblEnCokBesin;
        private Label lblIkinciUrun;
        private Label lblUcuncuUrun;
    }
}