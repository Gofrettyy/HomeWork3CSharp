using System;
namespace OOP3
{
    interface IKrediManager // okunurluğu arttırmak için biz interfaceleri I harfiyle Başlatırız ki bunun Interface olduğunu anlarız.
    {
        void Hesapla();
        void BiseyYap();
        
    }
}

// Tek başına anlam ifade etmeyen ama yan claslarının imzası  ebeveyni niteliğinde olan yani imzanın aynı olduğu ama içerisinin farklı olduğu classların ebeveynini yani KrediManagerı artık class değilde interface olarak ifade ederiz.

// interfaceler şöyle der eğer bir class beni kullanırsa benim içerdiğim methodlarıda içermek zorundadır.