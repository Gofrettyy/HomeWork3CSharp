using System;
namespace OOP3
{
    class BasvuruManager
    {    //Method injection yani hangi krediyi ve logu kullanacağını classa enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme 
            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}


