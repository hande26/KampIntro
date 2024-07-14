using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2

{//Individual
    public class GercekMusteri:Musteri  //Inharitance:Miras
    {

        //public int Id { get; set; }    --->Ortak özelllikler Musteri Classında olmalı
        //public string MusteriNo { get; set; }
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string TcNo { get; set; }

    }
}
