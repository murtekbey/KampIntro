using System;
using System.Linq; // Sum metodu kullanabilmek için import etmelisiniz.

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5)); // tüm sayıları toplar ve sonucu yazdırır.
        }

        static int Add(params int[] numbers) // istediğin kadar integer değer gönderebilirsin.
        {
            return numbers.Sum(); // Sum() methodu dizi içerisinde olan bütün sayıları toplar.
        }
    }
}
