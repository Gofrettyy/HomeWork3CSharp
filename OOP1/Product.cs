using System;
namespace OOP1
{
    // class oluştururken Primary Keyleri önce hemen sonrasındada Foreign Keyleri kullanmamız en doğru kullanım olacaktır
    // ürün gibi classlarda sadece özellik olur.
    // eklemek silmek güncellemek crud operasyonları diyoruz. Operasyon projelerinde genellikle veritabanı programlamasında kullanılır.
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ?ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }


    }
}

