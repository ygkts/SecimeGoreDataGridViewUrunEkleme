﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_InterfaceKullanimiDısardanGirerek
{
    class SilindirKutu
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public int Yukseklik { get; set; }
        public int Yaricap { get; set; }
        public int Hacim()
        {
            return Convert.ToInt32(Math.PI*Math.Pow(Yaricap,2)*Yukseklik);
        }
    }
}
