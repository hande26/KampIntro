using ClassMethotDemo;

public class Program
{
    public static void Main(string[] args)
    {
       
        Musteri musteri1 = new Musteri();
        musteri1.MusteriAdi = "HANDE";
        musteri1.MusteriDogumYili = 1995;
        musteri1.MusteriMeslegi = "BİLGİSAYAR MÜHENDİSİ";
        musteri1.MusteriMaasi = 26000;

        Musteri musteri2 = new Musteri();
        musteri2.MusteriAdi = "AHSEN";
        musteri2.MusteriDogumYili = 1995;
        musteri2.MusteriMeslegi = "ŞEHİR BÖLGE PLANLAMACI";
        musteri2.MusteriMaasi = 30000;

        Musteri musteri3 = new Musteri();
        musteri3.MusteriAdi = "SEVAL";
        musteri3.MusteriDogumYili = 1995;
        musteri3.MusteriMeslegi = "KİMYA MÜHENSDİSİ";
        musteri3.MusteriMaasi = 28000;

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.MusteriEkle(musteri1);
        musteriManager.MusteriEkle(musteri2);
        musteriManager.MusteriEkle(musteri3);

        Console.WriteLine("----------------------------");

        musteriManager.MusteriSilme(musteri1);
        musteriManager.MusteriSilme(musteri3);

        Console.WriteLine("----------------------------");

        Musteri[] musteriler =new Musteri[] { musteri1, musteri2 ,musteri3};
        musteriManager.MusteriListele(musteriler);

        Console.WriteLine("----------------------------");


        Musteri[] musteriBilgileri = new Musteri[] { musteri1, musteri2, musteri3 };
        musteriManager.MusteriBilgileri(musteriBilgileri);

    }
}