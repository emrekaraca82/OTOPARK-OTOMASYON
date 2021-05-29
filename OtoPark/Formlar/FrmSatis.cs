using OtoPark.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoPark.Formlar
{
    public partial class FrmSatis : Form
    {
        OtoParkDbContext db = new OtoParkDbContext();
        public FrmSatis()
        {
            InitializeComponent();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            TumKayitlar();
        }

        private void TumKayitlar()
        {
            #region kayitGöster
            var liste = (from x in db.Tbl_Satis
                         join
                       m in db.Tbl_Marka on x.MarkaID equals m.ID
                         join
                       s in db.Tbl_Seri on x.SeriID equals s.ID
                         join
                       p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).ToList();
            dataGridView1.DataSource = liste;

            lbltutar.Text = "Toplam Tutar=" + db.Tbl_Satis.Sum(x => x.Tutar);
            lblkayit.Text = "Toplam Kayit=" + db.Tbl_Satis.Count() + " Kayit Listelendi";
            lblortalama.Text = "Ortalama Tutar=" + db.Tbl_Satis.Average(x => x.Tutar);
            lblmax.Text = "En yüksek Tutar=" + db.Tbl_Satis.Max(x => x.Tutar);
            lblmin.Text = "En düşük Tutar=" + db.Tbl_Satis.Min(x => x.Tutar);

            #endregion
        }

      

        private void txtIDara_TextChanged(object sender, EventArgs e)
        {
            #region IDara
            var liste = (from x in db.Tbl_Satis
                         join
                       m in db.Tbl_Marka on x.MarkaID equals m.ID
                         join
                       s in db.Tbl_Seri on x.SeriID equals s.ID
                         join
                       p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }
                         ).Where(x => x.ID.ToString() == txtIDara.Text).ToList();
            dataGridView1.DataSource = liste;
            #endregion
        }

        private void txtMusteriIDara_TextChanged(object sender, EventArgs e)
        {
            #region MusIDara
            var liste = (from x in db.Tbl_Satis
                         join
                       m in db.Tbl_Marka on x.MarkaID equals m.ID
                         join
                       s in db.Tbl_Seri on x.SeriID equals s.ID
                         join
                       p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }
                         ).Where(x => x.MusteriID.ToString() == txtMusteriIDara.Text).ToList();
            dataGridView1.DataSource = liste;
            #endregion
        }

        private void txtAdsoyadara_TextChanged(object sender, EventArgs e)
        {
            #region Adsoyadara
            var liste = (from x in db.Tbl_Satis
                         join
                       m in db.Tbl_Marka on x.MarkaID equals m.ID
                         join
                       s in db.Tbl_Seri on x.SeriID equals s.ID
                         join
                       p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.AdiSoyadi.Contains(txtAdsoyadara.Text)).ToList();
            dataGridView1.DataSource = liste;          
            #endregion
        }

        private void txtPlakaara_TextChanged(object sender, EventArgs e)
        {
            #region Plakara
            var liste = (from x in db.Tbl_Satis
                         join
                       m in db.Tbl_Marka on x.MarkaID equals m.ID
                         join
                       s in db.Tbl_Seri on x.SeriID equals s.ID
                         join
                       p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }
                         ).Where(x => x.Plaka.Contains(txtPlakaara.Text)).ToList();
            dataGridView1.DataSource = liste;         
            #endregion
        }

        private void txtParkyeriara_TextChanged(object sender, EventArgs e)
        {
            #region Parkyeriara
            var liste = (from x in db.Tbl_Satis
                         join
                       m in db.Tbl_Marka on x.MarkaID equals m.ID
                         join
                       s in db.Tbl_Seri on x.SeriID equals s.ID
                         join
                       p in db.Tbl_AracParkYerleri on x.ParkYeriID equals p.ID
                         select new
                         {
                             x.ID,
                             x.SatisID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             m.MarkAdi,
                             s.seri,
                             p.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.SaatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }
                         ).Where(x => x.ParkYerleri.Contains(txtParkyeriara.Text)).ToList();
            dataGridView1.DataSource = liste;         
            #endregion
        }
    }
}
