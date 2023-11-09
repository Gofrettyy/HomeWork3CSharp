// konuşmamız gereken bir diğer konuda interfacelerdir.

using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasıtKrediManager = new TasıtKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
// Method injection bu işlem yazılımda sürdürülebilirliği sağlar.


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager ,tasıtKrediManager};
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

//Interfacelerde o ınterfacei ımplemente eden classın referans numarasını tutarlar.