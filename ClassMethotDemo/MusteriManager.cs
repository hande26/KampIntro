using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri eklendi :" +  musteri.MusteriAdi);

        }


        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(" Müşteri Silinmiştir. :" + musteri.MusteriAdi);

        }


        public void MusteriListele(Musteri [] musteriler)
        {
            foreach (Musteri m in musteriler)
            {
                Console.WriteLine ("Müşteriler " + m.MusteriAdi);
            }

        }


        public void MusteriBilgileri(Musteri [] musteriBilgileri)
        {
            foreach (Musteri item in musteriBilgileri)
            {
                Console.WriteLine("Müşteri Adı: "+ item.MusteriAdi);
                Console.WriteLine("Müşteri Doğum Yılı: " + item.MusteriDogumYili);
                Console.WriteLine("Müşteri Mesleği: " + item.MusteriMeslegi);
                Console.WriteLine("Müşteri Maaşı: " + item.MusteriMaasi);


            }

        }







    }
}
