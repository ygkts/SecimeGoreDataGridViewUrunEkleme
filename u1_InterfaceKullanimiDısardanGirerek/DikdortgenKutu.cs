using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_InterfaceKullanimiDısardanGirerek
{
    class DikdortgenKutu
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public int Yukseklik { get; set; }
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int Hacim()
        {
            return Convert.ToUInt16(KisaKenar*UzunKenar*Yukseklik);
        }
    }
}
