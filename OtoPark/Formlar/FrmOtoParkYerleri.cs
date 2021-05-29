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
    public partial class FrmOtoParkYerleri : Form
    {
        public FrmOtoParkYerleri()
        {
            InitializeComponent();
        }
        OtoParkDbContext db = new OtoParkDbContext();
        private void FrmOtoParkYerleri_Load(object sender, EventArgs e)
        {
            PanelParkYerleri();
            VeritabanıParkYerleri();

            var plakagöster = from x in db.Tbl_AracParkBilgileri
                              select new
                              {
                                  x.Plaka,
                                  x.ParkYeriID
                              };
            foreach (var item in plakagöster)
            {
                foreach (Control PlakaDurum in panel1.Controls)
                {
                    if(PlakaDurum.Name==item.ParkYeriID.ToString() &&PlakaDurum.BackColor == Color.Red)
                    {
                        PlakaDurum.Text = item.Plaka;
                    }
                }

                foreach (Control PlakaDurum in panel2.Controls)
                {
                    if (PlakaDurum.Name == item.ParkYeriID.ToString() && PlakaDurum.BackColor == Color.Red)
                    {
                        PlakaDurum.Text = item.Plaka;
                    }
                }
            }
        }

        private void VeritabanıParkYerleri()
        {
            var sorgu = from i in db.Tbl_AracParkYerleri
                        select new
                        {
                            i.Durumu,
                            i,
                            i.ID,
                            i.ParkYerleri
                        };

            foreach (var item in sorgu)
            {
                foreach (Control lbl in panel1.Controls)
                {
                    if (item.Durumu == "Boş" && item.ParkYerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Green;
                    }
                    if (item.Durumu == "Dolu" && item.ParkYerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }

                foreach (Control lbl in panel2.Controls)
                {
                    if (item.Durumu == "Boş" && item.ParkYerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Green;
                    }

                    if (item.Durumu == "Dolu" && item.ParkYerleri == lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }
                {

                }
            }
        }

        private void PanelParkYerleri()
        {
            int x = 1, y = 1, z = 11;

            foreach (Control item in panel1.Controls)
            {
                if (item is Label)
                {
                    item.Text = "A-" + x;
                    item.Name = x.ToString();
                    x++;
                }
            }

            foreach (Control item in panel2.Controls)
            {
                if (item is Label)
                {
                    item.Text = "B-" + y;
                    item.Name = z.ToString();
                    y++;
                    z++;
                }
            }
        }
    }
}
