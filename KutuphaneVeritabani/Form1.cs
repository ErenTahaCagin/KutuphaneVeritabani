using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneVeritabani
{
    public partial class Form1 : Form
    {
        KutuphaneDataContext db = new KutuphaneDataContext();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            ColTur.ValueMember = "Id";
            ColTur.DisplayMember = "KitapTuru";

            ColTur.DataSource = db.dbKitapTurleris.ToList();
        }

        
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            db.Connection.Open();

            if (db.Connection.State == ConnectionState.Open)
                MessageBox.Show("Bağlantı var!");
            else 
                MessageBox.Show("Bağlantı yok!");
        }

        private void btnIlkKGetir_Click(object sender, EventArgs e)
        {
            dbKitaplar kitap = db.dbKitaplars.FirstOrDefault(x => x.Id == Convert.ToInt32(txtId.Text));

            if (kitap != null)
            {
                txtKitapAdi.Text = kitap.KitapAdi;
                cbKitapTuru.SelectedValue = kitap.Turu;
                txtYazar.Text = kitap.Yazar;
                txtSSayisi.Text = kitap.SayfaSayisi.ToString();
                txtBasimYili.Text = kitap.BasimYili.ToString();
                txtRaf.Text = kitap.RafNo;
                txtAdet.Text = kitap.Adet.ToString();
            }
            else
                MessageBox.Show("Kayıt Yok!");
        }

        private void btnTumKitap_Click(object sender, EventArgs e)
        {
            List<dbKitaplar> liste = db.dbKitaplars.ToList();

            dataGridView1.DataSource = liste;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKTurGetir_Click(object sender, EventArgs e)
        {
            var liste = db.dbKitapTurleris.ToList();

            cbKitapTuru.DataSource = liste;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dbKitaplar kitap = db.dbKitaplars.FirstOrDefault(x => x.Id == Convert.ToInt32(txtId.Text));

            if (kitap != null)
            {
                txtKitapAdi.Text = kitap.KitapAdi;
                cbKitapTuru.SelectedValue = kitap.Turu;
                txtYazar.Text = kitap.Yazar;
                txtSSayisi.Text = kitap.SayfaSayisi.ToString();
                txtBasimYili.Text = kitap.BasimYili.ToString();
                txtRaf.Text = kitap.RafNo;
                txtAdet.Text = kitap.Adet.ToString();
            }
            else
                MessageBox.Show("Kayıt Yok!");
        }
    }
}
