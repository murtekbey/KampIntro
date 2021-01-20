using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Murat", "Efe", "Anıl", "Süleyman" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Mustafa";
            //Console.WriteLine(isimler[4]); // Mustafa
            //Console.WriteLine(isimler[0]);  // Boş gelir --> isimler için yeni bir array oluşturduk ve referans numarası değişti.
            //                                // Bu yüzden artık 0. index de eleman yok.

            List<string> isimler2 = new List<string> { "Murat", "Efe", "Anıl", "Süleyman" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Mustafa");
            Console.WriteLine(isimler2[4]); // Mustafa
            Console.WriteLine(isimler2[0]); // Murat


        }
    }
}
