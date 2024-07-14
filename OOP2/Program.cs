using OOP2;

public class Program
{
    public static void Main(string[] args)
    {

        GercekMusteri musteri1= new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Hande";
        musteri1.Soyadi = "Cesur";
        musteri1.TcNo = "85641239715";

        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "54678";
        musteri2.SirketAdi = "Kodlama.io";
        musteri2.VergiNo = "45688712";




        Musteri musteri3 = new GercekMusteri(); //Musteri sınıfı hem GercekMusterinin referansını tutabiliyor hem de 
        Musteri musteri4 = new TuzelMusteri();  //TuzelMusterinin referansını tutabiliyor.

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Add(musteri1);
        musteriManager.Add(musteri3);

    }
}