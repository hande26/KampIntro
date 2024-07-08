using Metotlar;

class Program
{
    // METODLAR= Tekrar tekrar kullanılabilirliği sağlayan kod bloları ---- DO NOT REPEAT
    // kendini tekrar eden kod blokları varsa metod oluştur.
    // Clean Code - Best Practice



    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Urun urun1= new Urun(); ///class oluşturmuştuk. veri tipi ve değişken gibi ör: int a=değer; gibi classa ait değişken tanımlandı.

        urun1.Adi = "Elma";
        urun1.Fiyatı = 15;
        urun1.Aciklama = "Amasya Elması";


        Urun urun2= new Urun();

        urun2.Adi = "Karpuz";
        urun2.Fiyatı = 80;
        urun2.Aciklama = "Diyarbakır Karpuzu";


        Urun[] Urunler = new Urun[] {urun1,urun2 };

        foreach(Urun hande in Urunler)    //foreach(var s in diziAdı)  bu şekilde kendi class ismi ile çağırılıyor.
        {
            Console.WriteLine(hande.Adi + "    " + hande.Aciklama + "    "+ hande.Fiyatı);
        }

        Console.WriteLine("---------------------Metodlar-----------------------");

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);  // Sepete eklendi : Elma 

        sepetManager.Ekle2("Armut","Yeşil armut",12);




    }

}
    