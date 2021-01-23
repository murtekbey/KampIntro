using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Interface belirli kurallar içerir. 
    // Onu implemente eden classlar kendine göre doldurmak durumundadır.
    // Miras alan classlar Interface'in kurallarına uymak zorundadır.
    // Birbirinin alternatifi olan fakat kod içeriklerini farklı olan içerikler için kullanırız.
    interface ICreditManager // Interfaceler genellikle operasyonel methodlarda kullanılır.
    {
        void Calculate();
        void DoSomething();
    }
}
