

using OOP1;

public class Program
{
    public static void Main(string[] args)
    {
       

        // Product oluşturma yöntemi 1:
        Product product1 =new Product();
        product1.Id = 1;
        product1.CategoryId = 2;  //Mobilya
        product1.ProductName = "Masa";
        product1.UnitPrice = 500;
        product1.UnitInStock = 3;

        // Product oluşturma yöntemi 2: (süslü parantez açılır!)
        Product product2 = new Product { Id = 2,CategoryId=5,UnitInStock=5,ProductName="Kalem",UnitPrice=35 }; //Bu şekilde de tanımlanabilirdi.

        //Normalde bu veriler hep kullanıcılardan alınacak. Kullanıcıdan ekran vasıtası ile alacağız.

        ProductManager productManager = new ProductManager();  //ProductManager türünde productManagerr oluşturdurduk, String isim; gibi düşün.
       // PascalCase    camelCase
       // Case sensitive :Büyük küçük harf duyarlılığı

        productManager.Add(product1); //Ürün eklenmiştir: Masa

        productManager.Topla2(3, 6);//9


    }
}