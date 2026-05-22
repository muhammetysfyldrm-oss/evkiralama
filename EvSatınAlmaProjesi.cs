using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvKiralamaVeSatınAlmaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Veri girişi kontrolü
            if (string.IsNullOrWhiteSpace(txtMetrekare.Text) ||
                string.IsNullOrWhiteSpace(txtKiraFiyati.Text) ||
                cmbOdaSayisi.SelectedIndex == -1 ||
                cmbIsitma.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm detayları (metrekare, oda sayısı, kira, ısıtma) doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sayısal değerlerin kontrolü
            if (!int.TryParse(txtMetrekare.Text, out int metrekare) || !decimal.TryParse(txtKiraFiyati.Text, out decimal kira))
            {
                MessageBox.Show("Metrekare ve Kira Fiyatı alanlarına geçerli sayısal değerler giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Değerleri okuma
            string odaSayisi = cmbOdaSayisi.SelectedItem.ToString();
            string isitma = cmbIsitma.SelectedItem.ToString();
            string esyaliDurumu = chkEsyali.Checked ? "Eşyalı" : "Eşyasız";

            // İlan formatı
            string ilanDetayi = $"Oda: {odaSayisi} | {metrekare} m² | {isitma} | {esyaliDurumu} | Fiyat: {kira:C}";

            // Listeye ekle
            lstEvler.Items.Add(ilanDetayi);

            MessageBox.Show("Ev ilanı başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Temizle
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtMetrekare.Clear();
            txtKiraFiyati.Clear();
            cmbOdaSayisi.SelectedIndex = -1;
            cmbIsitma.SelectedIndex = -1;
            chkEsyali.Checked = false;
        }
    }
}
