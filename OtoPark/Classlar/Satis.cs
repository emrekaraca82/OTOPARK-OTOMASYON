using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoPark.Classlar
{
    class Satis
    {
        public int ID { get; set; }
        public int SatisID { get; set; }
        public int MusteriID { get; set; }
        public String AdiSoyadi { get; set; }
        public String Telefon { get; set; }
        public int MarkaID { get; set; }
        public int SeriID { get; set; }
        public String Plaka { get; set; }
        public String Yil { get; set; }
        public String Renk { get; set; }
        public int ParkYeriID { get; set; }
        public decimal SaatUcreti { get; set; }
        public decimal Sure { get; set; }
        public decimal Tutar { get; set; }
        public String Aciklama { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }

    }
}
