using OtoPark.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoPark.Formlar
{
    public partial class FrmMusteriListele : Form
    {
        public FrmMusteriListele()
        {
            InitializeComponent();
        }

        OtoParkDbContext db = new OtoParkDbContext();
        private void FrmMusteriListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tbl_Musteri.ToList();
        }

        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            pictureBox1.ImageLocation = "";
            dateTimeTarih.Value = DateTime.Now;
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.Tbl_Musteri
                      where x.ID.ToString() == txtID.Text
                      select x;
            foreach (var item in ara)
            {
                txtAdiSoyadi.Text = item.AdiSoyadi;
                txtTelefon.Text = item.Telefon;
                txtAdres.Text = item.Adres;
                txtEmail.Text = item.Email;                    
                pictureBox1.ImageLocation = item.Resim;
                dateTimeTarih.Value = item.Tarih;
            }
            if (txtID.Text == "")
            {
                Temizle();
            }
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var addmusteri = new Musteri();
            addmusteri.AdiSoyadi = txtAdiSoyadi.Text;
            addmusteri.Telefon = txtTelefon.Text;
            addmusteri.Adres = txtAdres.Text;
            addmusteri.Email = txtEmail.Text;
            addmusteri.Resim = pictureBox1.ImageLocation;
            addmusteri.Tarih = dateTimeTarih.Value;
            db.Tbl_Musteri.Add(addmusteri);
            db.SaveChanges();
            MessageBox.Show("Müsteri Eklendi.", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Tbl_Musteri.ToList();
            Temizle();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.Tbl_Musteri.FirstOrDefault(x => x.ID == id);
            db.Tbl_Musteri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Müsteri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridView1.DataSource = db.Tbl_Musteri.ToList();
            Temizle();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtID.Text);
            var guncelle = db.Tbl_Musteri.FirstOrDefault(x => x.ID == id);
            guncelle.AdiSoyadi = txtAdiSoyadi.Text;
            guncelle.Telefon = txtTelefon.Text;
            guncelle.Adres = txtAdres.Text;
            guncelle.Email = txtEmail.Text;
            guncelle.Resim = pictureBox1.ImageLocation;
            guncelle.Tarih = dateTimeTarih.Value;
            db.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi.", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Tbl_Musteri.ToList();
            Temizle();
        }
    }
}
