using System;
namespace OOP1
{
    public class ProductManager
        //encapsulation  
    {
      public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
        public int Topla(int sayi1, int sayi2) //return kullanmamızın sebebi sonrasında projenin herhangi bir yerinde bu işlemi tekrardan kullanmak istiyorum.
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }

    /* VOİD nedir ? 
     void aslında daha çok emirleri gerçekleştirirken kullanılır ve o işlemi yaparken esktra bir bilgiye ihtiyacı olmaz.
     */
   
}

