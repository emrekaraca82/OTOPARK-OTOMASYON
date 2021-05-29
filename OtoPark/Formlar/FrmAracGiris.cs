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
    public partial class FrmAracGiris : Form
    {
        OtoParkDbContext db = new OtoParkDbContext();
        public FrmAracGiris()
        {
            InitializeComponent();
        }
       
        private void FrmAracGiris_Load(object sender, EventArgs e)
        {
            var markaGetir = db.Tbl_Marka.ToList();
            cmbMarka.DataSource = markaGetir;
            cmbMarka.DisplayMember = "MarkAdi";
            cmbMarka.ValueMember = "ID";

            ParkYerileriYenile();
        }

        private void ParkYerileriYenile()
        {
            var parkyerigetir = db.Tbl_AracParkYerleri.Where(x => x.Durumu == "Boş").ToList();
            cmbParkYeri.DataSource = parkyerigetir;
            cmbParkYeri.DisplayMember = "ParkYerleri";
            cmbParkYeri.ValueMember = "ID";
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var seriGetir = db.Tbl_Seri.Where(x => x.MarkaID == (int)cmbMarka.SelectedValue).ToList();
                cmbSeri.DataSource = seriGetir;
                cmbSeri.DisplayMember = "seri";
                cmbSeri.ValueMember = "ID";
            }
            catch (Exception)
            {

                
            }
        }

        private void cmbMarka_ValueMemberChanged(object sender, EventArgs e)
        {
            var seriGetir = db.Tbl_Seri.Where(x => x.MarkaID == (int)cmbMarka.SelectedValue).ToList();
            cmbSeri.DataSource = seriGetir;
            cmbSeri.DisplayMember = "seri";
            cmbSeri.ValueMember = "ID";
        }

        private void txtmusteriID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var musterigetirID = db.Tbl_Musteri.Where(x => x.ID.ToString() == txtmusteriID.Text).ToList();
                foreach (var item in musterigetirID)
                {
                    txtAdSoyad.Text = item.AdiSoyadi;
                    txtTelefon.Text = item.Telefon;              
                }
                if (txtmusteriID.Text=="")
                {
                    txtAdSoyad.Text = "";
                    txtTelefon.Text = "";
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            var aracparkadd = new AracParkBilgileri();
            aracparkadd.MusteriID = int.Parse(txtmusteriID.Text);
            aracparkadd.AdiSoyadi = txtAdSoyad.Text;
            aracparkadd.Telefon = txtTelefon.Text;
            aracparkadd.MarkaID = (int)cmbMarka.SelectedValue;
            aracparkadd.SeriID = (int)cmbSeri.SelectedValue;
            aracparkadd.Plaka = txtPlaka.Text;
            aracparkadd.Yil = txtYil.Text;
            aracparkadd.Renk = txtRenk.Text;
            aracparkadd.ParkYeriID = (int)cmbParkYeri.SelectedValue;
            aracparkadd.Aciklama = txtAciklama.Text;
            aracparkadd.GirisTarihi = DateTime.Now;
            db.Tbl_AracParkBilgileri.Add(aracparkadd);
            db.SaveChanges();

            var parkyerleridoldur = db.Tbl_AracParkYerleri.FirstOrDefault(x => x.ID == (int)cmbParkYeri.SelectedValue);
            parkyerleridoldur.Durumu = "Dolu";
            db.SaveChanges();

            MessageBox.Show("Otopark Araç Eklendi.", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btntemizle.PerformClick();
            ParkYerileriYenile();

        }      
    }
}
