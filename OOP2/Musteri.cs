using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Musteri  //Base-Temel sınıf
    {

        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public string TcNo { get; set; }
        //public string SirketAdi { get; set; }
        //public string VergiNo { get; set; }


        //eğer bir veri üzerinde matematiksel işlem yapılmazsa metinsel olarak planlanması daha doğrudur.
        //Bu nedenle TcNo/Vergino/MusteriNo alanlarınıstring tanımladık.

        //Eğer bir nesnede bir değeri kullanmak zorunda görünmüyorsak alan o nesneye ait değilmiş gibi duruyorsa hata var demektir.
        //İlk başta yukarıdaki gibiydi ama Musteri class özelliklerini Tüzel ve gerçek olarak ayırıyoruz.

        //-*---------------**********----------------*************----------
        public int Id { get; set; }
        public string MusteriNo { get; set; }





    }
}
