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
    public partial class FrmSeri : Form
    {
        public FrmSeri()
        {
            InitializeComponent();
        }
        OtoParkDbContext db = new OtoParkDbContext();
        private void FrmSeri_Load(object sender, EventArgs e)
        {
            SeriListele();
            var comboliste = db.Tbl_Marka.ToList();
            cmbmarka.DataSource = comboliste;
            cmbmarka.DisplayMember = "MarkAdi";
            cmbmarka.ValueMember = "ID";
        }

        private void SeriListele()
        {
            listView1.Items.Clear();
            var liste = from x in db.Tbl_Seri
                        join y in db.Tbl_Marka
                        on x.MarkaID equals y.ID
                        select new
                        {
                            x.ID,
                            y.MarkAdi,
                            x.seri
                        };
            foreach (var item in liste)
            {
                ListViewItem list = new ListViewItem(item.ID.ToString());
                list.SubItems.Add(item.MarkAdi);
                list.SubItems.Add(item.seri);
                listView1.Items.Add(list);

            }
        }
        void Temizle()
        {
            txtıd.Text = "";
            txtseri.Text = "";
            cmbmarka.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            int markaid = (int)cmbmarka.SelectedValue;
            var seriadd = new Seri();
            seriadd.MarkaID = markaid;
            seriadd.seri = txtseri.Text;
            db.Tbl_Seri.Add(seriadd);
            db.SaveChanges();
            MessageBox.Show("Araç Serisi Eklendi.", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SeriListele();
            Temizle();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ListViewItem secilenID = listView1.SelectedItems[0];
            int sil = int.Parse(secilenID.SubItems[0].Text);
            var seridelete = db.Tbl_Seri.FirstOrDefault(x => x.ID == sil);
            db.Tbl_Seri.Remove(seridelete);
            db.SaveChanges();
            MessageBox.Show("Araç Serisi Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SeriListele();
            Temizle();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int secilenID = int.Parse(txtıd.Text);
            var seriupdate = db.Tbl_Seri.FirstOrDefault(x => x.ID == secilenID);
            seriupdate.MarkaID = (int)cmbmarka.SelectedValue;
            seriupdate.seri = txtseri.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Serisi Güncellendi.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SeriListele();
            Temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                txtıd.Text = secilen.SubItems[0].Text;
                cmbmarka.Text = secilen.SubItems[1].Text;
                txtseri.Text = secilen.SubItems[2].Text;

            }
        }
    }
}
