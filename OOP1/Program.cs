using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2/*obje*/ = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };
            //PascalCase    //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);


            // int,double,bool... değer tip
            // diziler,class,abstract class,interface... referans tip

            int islemSonucu = productManager.Topla(3, 6);
            //Bir metodu returnleyerek yazarsan ileride onu kullanabilirsin. Ama void şelinde bir metod yazarsan bu çıktı ileride kullanılamaz.
            Console.WriteLine(islemSonucu);

            Console.WriteLine("işlem sonucuna 9 ekle");
            Console.WriteLine(islemSonucu+9);
            //ProductManager'daki Topla metodunu void yapmadığımız için burada kullanabildik...
    }
    }
}
