using System;
namespace Methods
{
    public class Urun 
    {   //aşağıdakilerden her biri bir propertydir.
        public int Id { get; set; } // ürünü diğerlerinden arıyan eşsiz değer Id'dir.
        public string ?Adi { get; set; }
        public double Fiyatı { get; set; }
        public string ?Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}

