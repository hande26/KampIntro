 class Program
{
    private static void Main(string[] args)
    {
        Kurs kurs1 = new Kurs(); //kurs tipinde kurs1 değişkeni tanımlandı.
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";
        kurs1.IzlenmeOrani = 68;


        Kurs kurs2 = new Kurs(); //kurs tipinde kurs2 değişkeni tanımlandı.
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.IzlenmeOrani = 64;

        Kurs kurs3 = new Kurs(); //kurs tipinde kurs3 değişkeni tanımlandı.
        kurs3.KursAdi = "Phyton";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlenmeOrani = 80;

        Kurs kurs4 = new Kurs(); //kurs tipinde kurs3 değişkeni tanımlandı.
        kurs4.KursAdi = "C++";
        kurs4.Egitmen = "Murat Kurtboğan";
        kurs4.IzlenmeOrani = 100;



        Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);
        Console.WriteLine("-------------------------");


        Kurs[] kurslar = new Kurs[]//string[] Kurslar = new string[] normalde bu şekilde yazıyorduk burda içerisinde sadece string tutabilirsin.
        //Biz class ile kendi değişkenimizi oluşturduk o nedenle class ın ismi ile oluşturuyoruz.!!!!!
        {
            kurs1,kurs2,kurs3,kurs4
        };

        foreach (var hande in kurslar) //var yerine = Kurs da yazılabilirdi.
        {
            Console.WriteLine(hande.KursAdi + "   " + hande.Egitmen);
        }



    }
}


class Kurs //kendi veri tipi yazıyormuşsun gibi düşün.
{
    public string KursAdi { get; set; }

    public string Egitmen { get; set; }

    public int IzlenmeOrani { get; set; }


}