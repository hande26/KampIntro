 class Program
{
    private static void Main(string[] args)
    {
        //Döngüler = Bir şeyleri tekrar etmek için kullanılan yapılardır.

        for (int i = 1; i <10; i++) //for (başlangıç değeri ; şart ; yapılacak işlem )  döngü verilen şart sağlanana kadar devam eder.
            //bu örnekte 1 den başla 10 dan küçük sayılara kadar 1 artırarak devam et.
        {
        Console.Write(i);//sonuc = 123456789
        
        }

        for (int i = 1; i < 10; i+=2) //2 şer 2şer arttır şeklinde.
        {
            Console.WriteLine(i);//sonuc = 13579

        }
        
        //Arraylar
        string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu"; 
        string kurs2 = "Programlamaya Başlangıç için Temel Kursu";
        string kurs3 = "Java Kursu";
        string kurs4 = "Phyton Kursu";
        string kurs5 = "C# Kursu";

        string[] Kurslar = new string[]//gerçek hayatta bu bir veri kaynağından geliyor metodlar çağırıyosun.
        {
            "Yazılım Geliştirici Yetiştirme Kursu",
            "Programlamaya Başlangıç için Temel Kursu",
            "Java Kursu",
            "Phyton Kursu",
            "C# Kursu"
        };


        for (int i = 0; i < Kurslar.Length; i++)
        {
            Console.WriteLine(Kurslar[i]);// ilk başta sadece i yazdık 012 şeklinde geldi sonrasında düzenledik doğru yazdı.
        }

        Console.WriteLine("---------------For Bitti-------------");

        foreach (string kurs in Kurslar)//dizi temelli yapıları tek tek dönmeye yarıyor. diziyi dolaşırken alias tanımlıyor onu yadırıyoruz.
        {
            Console.WriteLine(kurs);
        }




    }
}