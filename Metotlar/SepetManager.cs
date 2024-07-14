using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
       public void Ekle(Urun urun)  //Parametre yolladık
        {
            Console.WriteLine("Sepete eklendi :" + urun.Adi );

        }

        public void Ekle2(string urunAdi, string aciklama ,double fiyat)
        {

            Console.WriteLine("Tebrikler Sepete Eklendi " + urunAdi);

        }

    }
    //Bir classın sonunda yer alan manager, servis, DAL, data access, controller gibi ifadeler bir operasyonların tutulduğunu belirtir.
}
