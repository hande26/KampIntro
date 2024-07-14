using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>// Ben MYList'imde T ile çalışacağım demektir.
                         // Bana bir tip ver ben aşağıyı ona göre yapılandırcam demektir. İnt, String vs.
    {

        T[] items; // MyList'in çalışabilmesi için arka planda kullanılacak diziyi oluşturuyoruz.
        //Constractor   
        public MyList() //Class newlendiğinde bu metod otomatik çalışır.
        {
            items = new T[0];//Arrayı oluşturduk ve sıfır elemanlı
        }



        public void Add(T item) //(string item) normalde böyle yazıyorduk.Burada sadece string değer vermek zorunda oluyor.
                                //Onun yerine çalışacağım tipi o an programcı new lerken hangisini kullanıyorsa o olsun diyoruz.T yi kullanıyoruz.
        {
            T[] tempArray = items; // Geçici dizinin referansı items dizisinin referans adresidir. Artık elemanlar kaybolmaz.
                                   // Ondan sonra eleman sayısını bir arttırıyoruz.

            items = new T[items.Length+1]; //dizinin mevcut eleman sayısını bulduk new ile bir arttırdık.
            //Ancak 2.elemanı eklediğimizde dizinin diğer elemanları kayboluyor.(Referans değer )
            //Bunun için dizinin referans adresini bir üst satırdaki gibi geçici bir dizide tutuyoruz.


            //tempArrayda emanet edilen verileri geri almak için;
            //tempArrayın bütün elemanlarını itemsa geri atayacağız.
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i]; //Emanet edilen değerler sırasıyla items a geri atanır.          
            }

            items[items.Length-1] = item; // artık eklenmesi gereken son elemanı atadık.

        }


    }
}
