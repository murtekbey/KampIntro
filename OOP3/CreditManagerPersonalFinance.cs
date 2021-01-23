using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CreditManagerPersonalFinance : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
