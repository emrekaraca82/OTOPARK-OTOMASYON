using OtoPark.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoPark
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            Formlar.FrmMarka marka = new Formlar.FrmMarka();
            marka.Show();
        }

        private void btn_marka_Click(object sender, EventArgs e)
        {
            Formlar.FrmMarka marka = new Formlar.FrmMarka();
            marka.Show();
        }

        private void seriTool_Click(object sender, EventArgs e)
        {
            Formlar.FrmSeri seri = new Formlar.FrmSeri();
            seri.Show();
        }
        private void btn_seri_Click(object sender, EventArgs e)
        {
            Formlar.FrmSeri seri = new Formlar.FrmSeri();
            seri.Show();
        }

        private void btn_müs_listele_Click(object sender, EventArgs e)
        {
            Formlar.FrmMusteriListele musteriListele = new Formlar.FrmMusteriListele();
            musteriListele.Show();
        }

        private void btn_oto_yer_Click(object sender, EventArgs e)
        {
            Formlar.FrmOtoParkYerleri otoParkYerleri = new Formlar.FrmOtoParkYerleri();
            otoParkYerleri.Show();
        }

        private void btn_arac_oto_giris_Click(object sender, EventArgs e)
        {
            Formlar.FrmAracGiris aracGiris = new Formlar.FrmAracGiris();
            aracGiris.Show();
        }

        private void btn_arac_oto_cikis_Click(object sender, EventArgs e)
        {
            Formlar.FrmAracOtoParkCıkıs araccikis = new Formlar.FrmAracOtoParkCıkıs();
            araccikis.Show();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            Formlar.FrmSatis satis = new Formlar.FrmSatis();
            satis.Show();
        }
    }
}
