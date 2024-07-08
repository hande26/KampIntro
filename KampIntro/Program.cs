 class Program
{
    private static void Main(string[] args)
    {
        //Type safety = tip güvenliği
        string KategoriEtiketi = "Kategori";

        Console.WriteLine(KategoriEtiketi);
        //Console.WriteLine("Kategori");  bu şekilde de kullanılabilirdi ancak değişiklik yapılmak istense değiştirmek sıkıntı
        //Do not repeat yourself -Kendini Tekrarlama bu n edenle değişlen kullan

        int OgreciSayısı = 32000;
        double FaizOanı = 1.45;
        Boolean sistemeGirisYaptıMı=false;//gerçek hayatta bu true - false olma durumu veri kaynağından gelir.


        if (sistemeGirisYaptıMı==true)//şart geçerli ise aşağıdaki blok çalışsın
        {
            Console.WriteLine("Kullanıcı Ayarları Butonu");
        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }

        //şart blokları
        double dolarDun = 7.55;
        double dolarBugun = 7.55;

        if (dolarDun >dolarBugun) 
        { 
        Console.WriteLine("Azalış Butonnu");
        }
        else if (dolarDun <dolarBugun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else 
        {
            Console.WriteLine("Değişmedi Butonu");
        }


        









    }
}