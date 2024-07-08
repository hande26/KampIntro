public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        Console.WriteLine(sayi1);//30


        int [] sayilar1  = new int[] { 10, 20, 30 };

        int[] sayilar2 = new int[] { 100, 200, 300 };

        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        Console.WriteLine(sayilar1[0]);//999

        //int,decimal,float,double,bool = DEĞER TİP
        //array,class,interface = REFERANS TİP

        //Değer tipdeki işlemler  stackte gerçekleşir. Sadece değeri atar geçer bağlantı yok.
        //Referans tipteki işlemler Heap üzerinde olur. new dendiği anda heap de adres oluşturup oraya atar.
        //Değer tiplerde değer atılır ****** Referans Tiplerde adres atılır.
        //referans tipte tutulmayan adresler Garbet collector tarafınfan çöpe atılır silinir.



    }
}