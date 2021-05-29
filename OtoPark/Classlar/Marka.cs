using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoPark.Classlar
{
    class Marka
    {
        public int ID { get; set; }
        public string MarkAdi { get; set; }
        public virtual ICollection<Seri> seri { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }

    }
}
