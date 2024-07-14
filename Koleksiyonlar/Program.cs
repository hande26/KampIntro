using System.Collections;
using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        string[] isimler = new string []{"Engin","Murat","Kerem","Halil" };
        Console.WriteLine(isimler[0]);
        Console.WriteLine(isimler[1]);
        Console.WriteLine(isimler[2]);
        Console.WriteLine(isimler[3]);

        //Arraylar oluşturulduğunda o sınırlar arasında kalır.
        //dizileri genişletemiyoruz. genişletmeye çalışıp yeniden new lense bu sefer değerleri kaybediyoruz çünkü yeni adrese atıyor.

        isimler = new string[5];// burada yapılan new ile yeni bir adres tanımlandı ve isimler dizisi artık o adrese atandı.
        isimler[4] = "İlker";
        Console.WriteLine(isimler[4]);  //İlker ekrana gelir ancakkk ;
        Console.WriteLine(isimler[0]);  // 0. değer Engini yazmadı neden yeni adrese atadığı için onlar hep boş geldi sadece 4. indisde
        //İlker yazıyor---["","","","","İlker"]>  bu hale geldi yeni dizi.


        // Gerçek hayat projelerinde c# da array pek kullanmayız. Daha çok koleksiyonlar kullanırız.
        // Çünkü dizilere sonradan eleman eklenemiyor, out of range hatası alınıyor.
        Console.WriteLine("---------------------Koleksiyon Kullanımı----------------------");

        List<string > isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("İlker");  //Burada dizinin sınırını arttırmak istedik.
        Console.WriteLine(isimler2[4]);//İlker yazdı.
        Console.WriteLine(isimler2[0]);// Engin yazdı.  herhangi bir veri kaybı olmadı.

        






    }
}