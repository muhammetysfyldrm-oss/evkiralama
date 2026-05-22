namespace EvKiralamaVeSatınAlmaOtomasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblMetrekare = new System.Windows.Forms.Label();
            this.txtMetrekare = new System.Windows.Forms.TextBox();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.cmbOdaSayisi = new System.Windows.Forms.ComboBox();
            this.lblKiraFiyati = new System.Windows.Forms.Label();
            this.txtKiraFiyati = new System.Windows.Forms.TextBox();
            this.lblIsitma = new System.Windows.Forms.Label();
            this.cmbIsitma = new System.Windows.Forms.ComboBox();
            this.chkEsyali = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lstEvler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBaslik.Location = new System.Drawing.Point(30, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(232, 26);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ev Kiralama Sistemi";
            // 
            // lblMetrekare
            // 
            this.lblMetrekare.AutoSize = true;
            this.lblMetrekare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMetrekare.Location = new System.Drawing.Point(30, 80);
            this.lblMetrekare.Name = "lblMetrekare";
            this.lblMetrekare.Size = new System.Drawing.Size(106, 17);
            this.lblMetrekare.TabIndex = 1;
            this.lblMetrekare.Text = "Metrekare (m²):";
            // 
            // txtMetrekare
            // 
            this.txtMetrekare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetrekare.Location = new System.Drawing.Point(160, 77);
            this.txtMetrekare.Name = "txtMetrekare";
            this.txtMetrekare.Size = new System.Drawing.Size(150, 23);
            this.txtMetrekare.TabIndex = 2;
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaSayisi.Location = new System.Drawing.Point(30, 120);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(81, 17);
            this.lblOdaSayisi.TabIndex = 3;
            this.lblOdaSayisi.Text = "Oda Sayısı:";
            // 
            // cmbOdaSayisi
            // 
            this.cmbOdaSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaSayisi.FormattingEnabled = true;
            this.cmbOdaSayisi.Items.AddRange(new object[] {
            "1+0",
            "1+1",
            "2+1",
            "3+1",
            "4+1",
            "Villa"});
            this.cmbOdaSayisi.Location = new System.Drawing.Point(160, 117);
            this.cmbOdaSayisi.Name = "cmbOdaSayisi";
            this.cmbOdaSayisi.Size = new System.Drawing.Size(150, 24);
            this.cmbOdaSayisi.TabIndex = 4;
            // 
            // lblKiraFiyati
            // 
            this.lblKiraFiyati.AutoSize = true;
            this.lblKiraFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKiraFiyati.Location = new System.Drawing.Point(30, 160);
            this.lblKiraFiyati.Name = "lblKiraFiyati";
            this.lblKiraFiyati.Size = new System.Drawing.Size(107, 17);
            this.lblKiraFiyati.TabIndex = 5;
            this.lblKiraFiyati.Text = "Aylık Kira (TL):";
            // 
            // txtKiraFiyati
            // 
            this.txtKiraFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKiraFiyati.Location = new System.Drawing.Point(160, 157);
            this.txtKiraFiyati.Name = "txtKiraFiyati";
            this.txtKiraFiyati.Size = new System.Drawing.Size(150, 23);
            this.txtKiraFiyati.TabIndex = 6;
            // 
            // lblIsitma
            // 
            this.lblIsitma.AutoSize = true;
            this.lblIsitma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsitma.Location = new System.Drawing.Point(30, 200);
            this.lblIsitma.Name = "lblIsitma";
            this.lblIsitma.Size = new System.Drawing.Size(81, 17);
            this.lblIsitma.TabIndex = 7;
            this.lblIsitma.Text = "Isıtma Türü:";
            // 
            // cmbIsitma
            // 
            this.cmbIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsitma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIsitma.FormattingEnabled = true;
            this.cmbIsitma.Items.AddRange(new object[] {
            "Doğalgaz (Kombi)",
            "Merkezi",
            "Soba",
            "Klima",
            "Yerden Isıtma"});
            this.cmbIsitma.Location = new System.Drawing.Point(160, 197);
            this.cmbIsitma.Name = "cmbIsitma";
            this.cmbIsitma.Size = new System.Drawing.Size(150, 24);
            this.cmbIsitma.TabIndex = 8;
            // 
            // chkEsyali
            // 
            this.chkEsyali.AutoSize = true;
            this.chkEsyali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkEsyali.Location = new System.Drawing.Point(160, 240);
            this.chkEsyali.Name = "chkEsyali";
            this.chkEsyali.Size = new System.Drawing.Size(87, 21);
            this.chkEsyali.TabIndex = 9;
            this.chkEsyali.Text = "Eşyalı mı?";
            this.chkEsyali.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(160, 280);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 40);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "İlan Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.IndianRed;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(160, 330);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 35);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lstEvler
            // 
            this.lstEvler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstEvler.FormattingEnabled = true;
            this.lstEvler.ItemHeight = 16;
            this.lstEvler.Location = new System.Drawing.Point(340, 77);
            this.lstEvler.Name = "lstEvler";
            this.lstEvler.Size = new System.Drawing.Size(430, 292);
            this.lstEvler.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.lstEvler);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.chkEsyali);
            this.Controls.Add(this.cmbIsitma);
            this.Controls.Add(this.lblIsitma);
            this.Controls.Add(this.txtKiraFiyati);
            this.Controls.Add(this.lblKiraFiyati);
            this.Controls.Add(this.cmbOdaSayisi);
            this.Controls.Add(this.lblOdaSayisi);
            this.Controls.Add(this.txtMetrekare);
            this.Controls.Add(this.lblMetrekare);
            this.Controls.Add(this.lblBaslik);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ev Kiralama Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblMetrekare;
        private System.Windows.Forms.TextBox txtMetrekare;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.ComboBox cmbOdaSayisi;
        private System.Windows.Forms.Label lblKiraFiyati;
        private System.Windows.Forms.TextBox txtKiraFiyati;
        private System.Windows.Forms.Label lblIsitma;
        private System.Windows.Forms.ComboBox cmbIsitma;
        private System.Windows.Forms.CheckBox chkEsyali;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lstEvler;
    }
}
