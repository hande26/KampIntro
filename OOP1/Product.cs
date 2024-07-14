using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1      //Entitity varlık sınıfımız
                    // Bu tür classlarda sadece özellik olur! "prop" yazarak tab'larız.
                  
{
    public class Product 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  //foreign key referans anahtarlar.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }


    }
}
