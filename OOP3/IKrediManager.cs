using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public /*class*/ interface IKrediManager
    {
        public void Hesapla(); //Kredi çeşitlerine göre farklı hesaplamalar yapılır.

        //Metod imzasının aynı olduğu ancak içeriğinin değiştiği durumlarda Base metoddaki Classı Interface haline getiririz!!
        //Eğer bu interface kullanılırsa içerisindeki metodları kullanamak zorundadir.

        public void BiseyYap();


        






    }
}
