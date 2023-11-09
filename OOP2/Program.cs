//Soyutlamayı konuşacağız. Soyutlama sizi değerli yapacak olandır. Buna iyi çalışmalıyız. Ozellikle Interface Inheritance ve Abstrack sınıfları,nesneleri gerçek hayata uygulayabilmek çok önemlidir.

using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Engin";
musteri1.Soyadi = "Demiroğ";
musteri1.TcNo = " 1312312312";

//Kodlama.io
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "1234567890";


Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();
// eğer bir yerde new görürsen bellekteki referans noyu tuttuğunu bileceksin. Musteri classı ikisininde referansını tutabilir.
MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);









//Musteri musteri1 = new Musteri();
//musteri1.Adi = "Engin";
//musteri1.Soyadi = "Demiroğ";
//musteri1.Id = 1;
//musteri1.TcNo = "222222222";
//musteri1.MusteriNo = "122132";
//musteri1.SirketAdi = " ?"; // Bu tarz bir kullanım hatalıdır şirket adının gerçek kişiyle ne alakası var :))
////Hatasız kodlama yoktur :) Hatasız kul olmaz :D
////Gerçek ve Tüzel olmak üzere iki tane nesnem var ama birbirine benziyor diye birbiri yerine kullanılamazlar.  Evet ikiside müşteridir ama bunlar farklı müşteri tipleridir. 
