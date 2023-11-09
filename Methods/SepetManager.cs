using System;
namespace Methods
{
    //classların bir diğer kullanımıda
    //manager service dal controller gibi ifadeler görürsek bir operasyon tutuyor demektir işte classları burdada kullanabiliriz.
    // bu tarz ortak kodları yani ortak operasyonları biz gidip yine classın içinde tutarız. sepete ekleme sepeti gösterme listeleme gibi işleri method olarak bu şekilde gruplandırırız.
    public class SepetManager
    {
        // naming convention Methoların ilk harfleri büyük başlar.
        // method parantezinin içine veri tipinden sonra tanımladığımız şeye parametre diyoruz
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler,Sepete eklendi:" + urun.Adi);
        }

        //Aşağıdaki çok hatalı bir kullanımdır.
        public void Ekle2 (string urunAdi, string Aciklama,Double Fiyat)
        {
            Console.WriteLine("Tebrikler,Sepete eklendi:" + urunAdi);
        }
    }
}

