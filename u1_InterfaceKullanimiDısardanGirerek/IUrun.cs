using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_InterfaceKullanimiDısardanGirerek
{
    interface IUrun
    {
        int Id { get; set; }
        string UrunAd { get; set; }
        int Yukseklik { get; set; }
        int Hacim();
    }
}
