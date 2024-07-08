using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Urun
    {
        public int Id { get; set; }  // bir datayı diğerlerinden ayıran eşsiz değer
        public string Adi { get; set; }
        public double Fiyatı { get; set; }
        public string Aciklama { get; set; }

    }
}
