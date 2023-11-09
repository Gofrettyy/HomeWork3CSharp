
//gerçek hayatta arraylerle çalışırken arraylere yeni bir veri ekleyemiyoruz eklemeye çalıştığımızdaysa onu heap tarafında newlemek durumunda kaldığımızdan önceki verilerle çalışamıyoruz işte bu soruna çözüm olarak koleksiyonlarla çalışırız. iş yaşamında daha çok koleksiyonlarla çalışırız.
using System;
using System.Collections.Generic;

List<string> isimler2 = new List<string>  {"Engin ","Murat","Kerem","Halil" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("İlker");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);

