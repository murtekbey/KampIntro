using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product telephone = new Product(50);
            telephone.ProductName = "Telefon";
            telephone.StockControlEvent += Telephone_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                telephone.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Telephone_StockControlEvent()
        {
            Console.WriteLine("Telephone about to finish");
        }
    }
}
