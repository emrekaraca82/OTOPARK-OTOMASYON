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
    public partial class FrmAracOtoParkCıkıs : Form
    {
        OtoParkDbContext db = new OtoParkDbContext();
        public FrmAracOtoParkCıkıs()
        {
            InitializeComponent();
        }

        private void FrmAracOtoParkCıkıs_Load(object sender, EventArgs e)
        {
            cmbSaatUcreti.SelectedIndex = 0;
          
           

            Yenile();
            var markagetir = db.Tbl_Marka.ToList();
            cmbMarka.DataSource = markagetir;
            cmbMarka.DisplayMember = "MarkAdi";
            cmbMarka.ValueMember = "ID";
        }

        private void Yenile()
        {
            cmbPlakaAra.Text = "";
            cmbPlakaAra.Items.Clear();
            var plakaGetir = db.Tbl_AracParkBilgileri.ToList();
            foreach (var item in plakaGetir)
            {
                cmbPlakaAra.Items.Add(item.Plaka);
            }
            var bosParkYerleri = db.Tbl_AracParkYerleri.Where(x => x.Durumu == "Boş").ToList();
            cmbParkYeri.DataSource = bosParkYerleri;
            cmbParkYeri.DisplayMember = "ParkYerleri";
            cmbParkYeri.ValueMember = "ID";

            var doluParkYerleri = db.Tbl_AracParkYerleri.Where(x => x.Durumu == "Dolu").ToList();
            cmbParkYeriAra.DataSource = doluParkYerleri;
            cmbParkYeriAra.DisplayMember = "ParkYerleri";
            cmbParkYeriAra.ValueMember = "ID";
            cmbParkYeriAra.Text = "";
            cmbParkYeri.Text = "";

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

        void UcretHesapla()
        {
            try
            {
                lblcikistarihi.Text = DateTime.Now.ToString();
                TimeSpan fark;
                fark = DateTime.Parse(lblcikistarihi.Text) - DateTime.Parse(lblgiristarihi.Text);
                decimal saatucreti = 0, sure = 0, tutar = 0;
                lblsure.Text = fark.TotalHours.ToString("0.00");
                saatucreti = decimal.Parse(cmbSaatUcreti.Text);
                sure = decimal.Parse(lblsure.Text);
                tutar = sure * saatucreti;
                lblücret.Text = tutar.ToString("0.00");

            }
            catch (Exception)
            {

                
            }
        }
        private void txtIDara_TextChanged(object sender, EventArgs e)
        {
            if(txtIDara.Text == "")
            {
                foreach (Control item in panelbilgiler.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            var araID = (from x in db.Tbl_AracParkBilgileri 
                          join
                        m in db.Tbl_Marka on x.MarkaID equals m.ID
                          join
                        s in db.Tbl_Seri on x.SeriID equals s.ID
                          join
                        p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Aciklama,
                             x.Telefon,
                             x.Plaka,
                             x.Renk,
                             x.GirisTarihi,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri
                         }
                         ).Where(ara => ara.ID.ToString() == txtIDara.Text).ToList();

            foreach (var item in araID)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdiSoyadi;
                txtAciklama.Text = item.Aciklama;
                txtTelefon.Text = item.Telefon;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                cmbMarka.Text = item.MarkAdi;
                cmbSeri.Text = item.seri;
                cmbParkYeri.Text = item.ParkYerleri;
                UcretHesapla();
            }
        }

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            if (txtMusteriAra.Text == "")
            {
                foreach (Control item in panelbilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            var araMusteriID = (from x in db.Tbl_AracParkBilgileri
                         join
                       m in db.Tbl_Marka on x.MarkaID equals m.ID
                         join
                       s in db.Tbl_Seri on x.SeriID equals s.ID
                         join
                       p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Aciklama,
                             x.Telefon,
                             x.Plaka,
                             x.Renk,
                             x.GirisTarihi,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri
                         }
                         ).Where(ara => ara.MusteriID.ToString() == txtMusteriAra.Text).ToList();

            foreach (var item in araMusteriID)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdiSoyadi;
                txtAciklama.Text = item.Aciklama;
                txtTelefon.Text = item.Telefon;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                cmbMarka.Text = item.MarkAdi;
                cmbSeri.Text = item.seri;
                cmbParkYeri.Text = item.ParkYerleri;
                UcretHesapla();
            }
        }

        private void txtAdsoyadAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAdsoyadAra.Text == "")
            {
                foreach (Control item in panelbilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            var araAdsoyadID = (from x in db.Tbl_AracParkBilgileri
                                join
                              m in db.Tbl_Marka on x.MarkaID equals m.ID
                                join
                              s in db.Tbl_Seri on x.SeriID equals s.ID
                                join
                              p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Aciklama,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.GirisTarihi,
                                    m.MarkAdi,
                                    s.seri,
                                    p.ParkYerleri
                                }
                         ).Where(ara => ara.AdiSoyadi.ToString() == txtAdsoyadAra.Text).ToList();

            foreach (var item in araAdsoyadID)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdiSoyadi;
                txtAciklama.Text = item.Aciklama;
                txtTelefon.Text = item.Telefon;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                cmbMarka.Text = item.MarkAdi;
                cmbSeri.Text = item.seri;
                cmbParkYeri.Text = item.ParkYerleri;
                UcretHesapla();
            }
        }

        private void cmbPlakaAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            var araPlaka = (from x in db.Tbl_AracParkBilgileri
                                join
                              m in db.Tbl_Marka on x.MarkaID equals m.ID
                                join
                              s in db.Tbl_Seri on x.SeriID equals s.ID
                                join
                              p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Aciklama,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.GirisTarihi,
                                    m.MarkAdi,
                                    s.seri,
                                    p.ParkYerleri
                                }
                        ).Where(ara => ara.Plaka.ToString() == cmbPlakaAra.Text).ToList();

            foreach (var item in araPlaka)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdiSoyadi;
                txtAciklama.Text = item.Aciklama;
                txtTelefon.Text = item.Telefon;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                cmbMarka.Text = item.MarkAdi;
                cmbSeri.Text = item.seri;
                cmbParkYeri.Text = item.ParkYerleri;
                UcretHesapla();
            }
        }

        private void cmbParkYeriAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            var araYeriPlaka = (from x in db.Tbl_AracParkBilgileri
                            join
                          m in db.Tbl_Marka on x.MarkaID equals m.ID
                            join
                          s in db.Tbl_Seri on x.SeriID equals s.ID
                            join
                          p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                            select new
                            {
                                x.ID,
                                x.MusteriID,
                                x.AdiSoyadi,
                                x.Aciklama,
                                x.Telefon,
                                x.Plaka,
                                x.Renk,
                                x.GirisTarihi,
                                m.MarkAdi,
                                s.seri,
                                p.ParkYerleri
                            }
                       ).Where(ara => ara.ParkYerleri.ToString() == cmbParkYeriAra.Text).ToList();

            foreach (var item in araYeriPlaka)
            {
                txtID.Text = item.ID.ToString();
                txtMusteriID.Text = item.MusteriID.ToString();
                txtAdSoyad.Text = item.AdiSoyadi;
                txtAciklama.Text = item.Aciklama;
                txtTelefon.Text = item.Telefon;
                txtPlaka.Text = item.Plaka;
                txtRenk.Text = item.Renk;
                lblgiristarihi.Text = item.GirisTarihi.ToString();
                cmbMarka.Text = item.MarkAdi;
                cmbSeri.Text = item.seri;
                cmbParkYeri.Text = item.ParkYerleri;
                UcretHesapla();
            }
        }

        private void cmbPlakaAra_TextChanged(object sender, EventArgs e)
        {
            if (cmbPlakaAra.Text == "")
            {
                foreach (Control item in panelbilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void cmbParkYeriAra_TextChanged(object sender, EventArgs e)
        {
            if (cmbParkYeriAra.Text == "")
            {
                foreach (Control item in panelbilgiler.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnparkyeriguncelle_Click(object sender, EventArgs e)
        {
            var DoluParkYerleriDegistir = db.Tbl_AracParkYerleri.FirstOrDefault(x => x.ParkYerleri == cmbParkYeriAra.Text);
            DoluParkYerleriDegistir.Durumu = "Boş";
            db.SaveChanges();

            var BosParkYerleriDegistir = db.Tbl_AracParkYerleri.FirstOrDefault(x => x.ParkYerleri == cmbParkYeri.Text);
            BosParkYerleriDegistir.Durumu = "Dolu";
            db.SaveChanges();

            var AracParkYeriDegistir = db.Tbl_AracParkBilgileri.FirstOrDefault(x => x.Plaka == txtPlaka.Text);
            AracParkYeriDegistir.ParkYeriID = (int)cmbParkYeri.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbParkYeriAra.Items.Clear();
            Yenile();
            btntemizle.PerformClick();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in panelarama.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                if(item is ComboBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in panelbilgiler.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                if (item is ComboBox)
                {
                    if (item!= cmbSaatUcreti)
                    {
                        item.Text = "";
                    }              
                }
            }


            lblsure.Text = "0.00";
            lblücret.Text = "0.00";
            lblcikistarihi.Text = DateTime.Now.ToString();
            lblgiristarihi.Text = DateTime.Now.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            #region sil
            Kayitsil();
            #endregion

            MessageBox.Show("Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbParkYeriAra.Items.Clear();
            Yenile();
            btntemizle.PerformClick();

            lblsure.Text = "0.00";
            lblücret.Text = "0.00";
            lblcikistarihi.Text = DateTime.Now.ToString();
            lblgiristarihi.Text = DateTime.Now.ToString();
        }

        private void Kayitsil()
        {
            var sil = db.Tbl_AracParkBilgileri.FirstOrDefault(x => x.Plaka == txtPlaka.Text);
            db.Tbl_AracParkBilgileri.Remove(sil);
            db.SaveChanges();

            var aracparkyeribosalt = db.Tbl_AracParkYerleri.FirstOrDefault(x => x.ParkYerleri == cmbParkYeri.Text);
            aracparkyeribosalt.Durumu = "Boş";
            db.SaveChanges();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            #region araccikisi
            if (cmbParkYeriAra.Text!="")
            {
                var ekle = new Satis();
                ekle.SatisID = int.Parse(txtID.Text);
                ekle.MusteriID = int.Parse(txtMusteriID.Text);
                ekle.AdiSoyadi = txtAdSoyad.Text;
                ekle.Telefon = txtTelefon.Text;
                ekle.MarkaID = (int)cmbMarka.SelectedValue;
                ekle.SeriID = (int)cmbSeri.SelectedValue;
                ekle.Plaka = txtPlaka.Text;
                ekle.Yil = "Belirtilmedi";
                ekle.Renk = txtRenk.Text;
                ekle.ParkYeriID = (int)cmbParkYeriAra.SelectedValue;
                ekle.SaatUcreti = decimal.Parse(cmbSaatUcreti.Text);
                ekle.Sure = decimal.Parse(lblsure.Text);
                ekle.Tutar = decimal.Parse(lblücret.Text);
                ekle.Aciklama = txtAciklama.Text;
                ekle.GirisTarihi = DateTime.Parse(lblgiristarihi.Text);
                ekle.CikisTarihi = DateTime.Parse(lblcikistarihi.Text);
                db.Tbl_Satis.Add(ekle);
                db.SaveChanges();
                MessageBox.Show("Araç Otopark Çıkışı Yapıldı ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kayitsil();
                Yenile();
                btntemizle.PerformClick();

                lblsure.Text = "0.00";
                lblücret.Text = "0.00";
                lblcikistarihi.Text = DateTime.Now.ToString();
                lblgiristarihi.Text = DateTime.Now.ToString();
                
            }
            else
            {
                MessageBox.Show("Dolu park yerinin seçilmesi gerekir ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
          
        }

        private void cmbSaatUcreti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            var guncelle = db.Tbl_AracParkBilgileri.FirstOrDefault(x => x.ID.ToString() == txtID.Text);
            guncelle.MarkaID = (int)cmbMarka.SelectedValue;
            guncelle.SeriID = (int)cmbSeri.SelectedValue;
            guncelle.ParkYeriID = (int)cmbParkYeri.SelectedValue;
            guncelle.Plaka = txtPlaka.Text;
            guncelle.Renk = txtRenk.Text;
            guncelle.Aciklama = txtAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Otopark Güncellendi ", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            Yenile();
            btntemizle.PerformClick();

            lblsure.Text = "0.00";
            lblücret.Text = "0.00";
            lblcikistarihi.Text = DateTime.Now.ToString();
            lblgiristarihi.Text = DateTime.Now.ToString();
        }
    }
}
