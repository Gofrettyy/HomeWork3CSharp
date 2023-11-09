
// methodlar tekrar tekrar kullanılabilirliği sağlar.
using Methods;

Urun urun1= new Urun(); //stok takip sistemi oluşturulurken yapılır
urun1.Adi = "Elma";
urun1.Fiyatı = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun(); // urun2 adında nesne oluşturduk ve özelliklerini girdik.
urun2.Adi = "Karpuz";
urun2.Fiyatı = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

//Array ne kadar data eklersen o datayı tutan yapıya array denir. Çoğul isimlendirilir.
Urun[] urunler = new Urun[]
{
    urun1,urun2
};
// gerçek hayatta veriler bir veri kaynağından gelir
// veri tipini yazıyoruz döngüde çünkü C# tip güvenli bir dildir.type-safe
foreach (Urun urun in urunler) // var keyworduylede kullanabilirdik
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(urun.Fiyatı);
    Console.WriteLine("---------------");
}

// yukarıda aslında söylediğimiz şey urunlerin her bir elemanını tek tek gez demiş


Console.WriteLine("-------------Methodlar---------------");
//instance ynai class örneği oluşturmak

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.Ekle2("Armut", "Yeşil armut", 12); 
/* bir methodu çağırmak için önce class örneği oluşturuyoruz sonra altına gelip class dosyasının içinde oluşturduğumuz methodu (bu örnek için sepetManager.Ekle();) bu şekilde artık çağırabiliriz.*/
// methodları kullandığımızda kodun tekrar kullanım yani reuse imkanınıda methodlar bize veriyor.Şimdi gidip SepetManager classında bir değişiklik yapsam bana buradaki çağırdığımız methodlarda değişmiş olarak gelecektir.
// ekle2 methodundaki kullanım yanlıştır çünkü sonrasında bir değişiklik yapmak istediğimde hepsinde teker teker değişiklik yapmayı gerektirecek o yüzden class kullanmamız gerekiyor.