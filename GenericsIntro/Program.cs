
using GenericsIntro;
// MyList classında tipi T olarak vermiştik bu yüzden gelip burada yazdığımız class örneklendirmesine yazacağım verilerin tipini belirtmek zorundayım.
// generic yapılara bir örnek
MyList<string> isimler = new MyList<string>();
isimler.Add("Engin");

List<string> liste = new List<string>();
Console.WriteLine(liste.Count);

