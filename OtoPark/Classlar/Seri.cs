using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoPark.Classlar
{
    class Seri
    {
        public int ID { get; set; }
        public int MarkaID { get; set; }
        public String seri { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }

    }
}
