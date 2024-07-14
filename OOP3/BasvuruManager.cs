using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager
    {

        public  void BasvuruYap(IKrediManager krediManager, ILoggerServise loggerServise)//Tüm kredilerin referansını tutabilen interface ile parametre yollandı.
        {
            //Başvuran bilgilerini değerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();----> Bu şekilde kullanımda tüm basvurular konut kredisine bağımlı hale gelir. 

            krediManager.Hesapla();
            loggerServise.Log();

        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler ) //bilgilendirme verilecek Kredi sayısı belli değil 
          //  Bİr tane de olabilir birden fazla da olabilir.
        {
            //Listedeki her bir veriyi dolaşmak gerekiyor.
            foreach(var m in krediler)
            {
                m.Hesapla();
            }
        }






    }
}
