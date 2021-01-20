using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Murat");

            Console.WriteLine(isimler.Length);

            isimler.Add("Anıl");

            Console.WriteLine(isimler.Length);

            isimler.Add("Süleyman");

            Console.WriteLine(isimler.Length);

            isimler.Add("Efe");

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
