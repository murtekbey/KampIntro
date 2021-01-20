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

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);
        }
    }
}
