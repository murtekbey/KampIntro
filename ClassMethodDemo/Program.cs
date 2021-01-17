using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Murat";
            customer1.Surname = "Altınpınar";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Süleyman";
            customer2.Surname = "Yaka";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Anıl";
            customer3.Surname = "Koralay";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Mustafa";
            customer4.Surname = "Gündoğdu";

            Customer customer5 = new Customer();
            customer5.Id = 5;
            customer5.Name = "Mustafa";
            customer5.Surname = "Çağatay";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            CustomerManager customerManager = new CustomerManager();

            foreach (Customer customer in customers)
            {
                customerManager.Add(customer); // Ekle
                customerManager.Remove(customer); // Sil
                customerManager.Get(customer); // Listele
                Console.WriteLine("----------------------------");
            }
        }
    }
}
