using OOP3;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        IhtiyacKrediManager ıhtiyacKrediManager= new IhtiyacKrediManager();
        //IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();  bu şekiilde densede olur .
        //ıhtiyacKrediManager.Hesapla();

        TasitKrediManager tasitKrediManager = new TasitKrediManager();
        //IKrediManager tasitKrediManager = new TasitKrediManager();
        //tasitKrediManager.Hesapla();

        KonutKrediManager konutKrediManager=new KonutKrediManager();
        //IKrediManager konutKrediManager = new KonutKrediManager()
        //konutKrediManager.Hesapla();

        //İnterface de İmplements ettikleri classların referans değerlerini tutarlar.New lenebilirler.


        Console.WriteLine("------------------------------------------------");

        BasvuruManager basvuruManager = new BasvuruManager();
        //basvuruManager.BasvuruYap(konutKrediManager);  interface ekleyince parametre olarak onu da bekledi ondan uyarı veriyor.
        //basvuruManager.BasvuruYap(tasitKrediManager);
        //basvuruManager.BasvuruYap(ıhtiyacKrediManager);

        Console.WriteLine("------------------------------------------------");

        List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager,tasitKrediManager};
        basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        Console.WriteLine("------------------------------------------------");

        ILoggerServise databaseLoggerService = new DatabaseLoggerService();
        ILoggerServise fileLoggerService = new FileLoggerService();


        basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);//Konut kredisi Ödeme Planı hesaplandı  Veri tabanına loglandı.
            








    }
}