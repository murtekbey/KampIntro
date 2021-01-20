using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T --> type
                    // Generic Classlarda çalışacağın tipi söylemen gerekiyor.
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // önceki değerleri korumak için tempArray ekledik.
            items = new T[items.Length+1]; // yeni bir eleman gönderildiği için arrayin alabileceği eleman değerini 1 arttırdığımız yeni bi array oluşturduk.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // yedek arraydeki bilgileri oluşturduğumuz yeni arraye for döngüsüyle tek tek index numarasına göre ekledik.
            }

            items[items.Length - 1] = item; // son olarak fonksiyondan gönderilen itemi sonuncu eleman olarak ekle.
        }

    }
}
