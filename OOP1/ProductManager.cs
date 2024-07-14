using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager //Product ile ilgili operasyonlar var içerisinde.
    {
        //Encapsulation
        public void Add(Product product)   //Parametre yollandı. String ad gibi düşün.
        {
            //product.ProductName = "Kamera";  bu şekilde başka bir değer atandığında artık masa olsada sonuç kamere döner çünkü
            //referans değerler heap de çalışır.
            Console.WriteLine(product.ProductName + "eklendi " );

        }


        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi. ");
        }

        //void = emir kipi gibi düşün ekle/update et/sil  işlem yapıp bitiyor
        // işlemi sonucunda olup bitenle bir ilişkin yok.


        public int Topla(int sayi1,int sayi2)//bu metodu kullanırsa sonucunda int tipinde bir değer verir.
        // Return, değer döndüren metotlardır. Sonucunda oluşan değer tekrar kullanabilir, Üzerinde çalışabilir ve işlemlere sokabiliriz.
        {
            return sayi1 + sayi2;
        }


        public void Topla2(int sayi1, int sayi2)// Tek seferlik iş yapan metotlardır. Sonucu tekrar kullanamayız. Başka işleme sokamayız.
        {
            Console.WriteLine( sayi1 + sayi2);
        }








    }
}
