﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2

{//Coorporate
    public class TuzelMusteri:Musteri //Inheritance:Miras
    {

        //public int Id { get; set; }     --->Ortak özelllikler Musteri Classında olmalı
        //public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
