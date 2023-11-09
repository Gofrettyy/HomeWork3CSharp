using System;
namespace GenericsIntro
{
    public class MyList <T> // ben mylistimde T ile çalışıcam demek T veriyorum ki o an programcı kodu yazarken hangi tip ile çalışmak istiyorsa onunla çalışabilsin.
    {
        // aşağıdakine constructor denir yani newlediğin anda çalışan bloğa denir
        T[] ?items ;
        public MyList() //ctor yazıp oluşturdum
        {
            items = new T[0]; 
        }

        public void Add(T item)
    
        {
            T[]? tempArray = items;
           items= new T[items!.Length + 1];
            for (int i = 0; i< tempArray!.Length; i++)
            {
                items[i] = tempArray[i];  //burada geçici arrayin tuttuğu verileri artık kullanmak için istiyorum.
            }
            items[items.Length - 1] = item; //eklenmek istenilen elemanı şuan eklemiş oldum arrayin sonuna.


        }
        //eleman sayısını artırırken önceki arraydeki verileri geçici bir arraye emanet ederiz ve sonrasındada arrayin içindeki elemen sayısını attırabiliriz
    }
}

