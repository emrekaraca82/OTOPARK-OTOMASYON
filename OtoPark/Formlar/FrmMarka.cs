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
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }

        OtoParkDbContext db = new OtoParkDbContext();

        private void FrmMarka_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void MarkaListele()
        {
            listView1.Items.Clear();
            var markalistele = db.Tbl_Marka.ToList();
            for (int i = 0; i < markalistele.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(markalistele[i].ID.ToString());
                ekle.SubItems.Add(markalistele[i].MarkAdi);
                listView1.Items.Add(ekle);
            }
        }

        void Temizle()
        {
            txtID.Text = "";
            txtMarka.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            var mrkadd = new Marka();
            mrkadd.MarkAdi = txtMarka.Text;
            db.Tbl_Marka.Add(mrkadd);
            db.SaveChanges();
            MessageBox.Show("Araç Markası Eklendi.", "Kayit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count>0)
            {
                txtID.Text = secilen.SubItems[0].Text;
                txtMarka.Text = secilen.SubItems[1].Text;

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ListViewItem secilenID = listView1.SelectedItems[0];
            int sil = int.Parse(secilenID.SubItems[0].Text);
            var mrkdelete = db.Tbl_Marka.FirstOrDefault(x => x.ID == sil);
            db.Tbl_Marka.Remove(mrkdelete);
            db.SaveChanges();
            MessageBox.Show("Araç Markası Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MarkaListele();
            Temizle();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int secilenID = int.Parse(txtID.Text);
            var mrkupdate = db.Tbl_Marka.FirstOrDefault(x => x.ID ==secilenID);
            mrkupdate.MarkAdi = txtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Markası Güncellendi.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MarkaListele();
            Temizle();
        }
    }
}
