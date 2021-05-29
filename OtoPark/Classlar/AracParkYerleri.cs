using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoPark.Classlar
{
    class AracParkYerleri
    {
        public int ID { get; set; }
        public String ParkYerleri { get; set; }
        public String Durumu { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileris { get; set; }
    }
}
