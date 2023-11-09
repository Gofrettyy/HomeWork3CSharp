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
            product1.UnitInStock = 3;

            // yukarıdaki örneği aşağıdaki gibi de yazabiliriz.
            Product product2 = new Product
            {
                Id =2, CategoryId=5,UnitInStock=5,
                ProductName="Kalem" , UnitPrice = 35
            };
            //PascalCase       //camelCase    //case sensitivi bir dildir.
            ProductManager productManager = new ProductManager(); // newlememizin sebebi referans tipin heapte oluşabilmesi içindir. //instance creation = bir sınıfın örneğini oluşturma
            // yukarıdaki şey aslında  bunun gibi bi şey string isim = "Engin";
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

         
        }
        // Gerçek hayatta bu verileri biz ekranda kullanıcıdan alırız.

        
    }
}