using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Murat Altınpınar
            //Customer customer1 = new Customer();
            //customer1.Id = 1;
            //customer1.FirstName = "Murat";
            //customer1.LastName = "Altınpınar";
            //customer1.TCNumber = "12314123435";
            //customer1.CustomerNumber = "14123";
            //customer1.CompanyName = "?";
            //customer1.TaxNumber = "?";
            // --> Hatalı tasarım.
            // Gerçek Müşteri - Tüzel Müşteri --> Bunlar sırf benziyor diye birbirinin yerine kullanılamaz.
            // SO(L)ID --> SOLID tasarım da L harfi bize bunu söyler.


            // Doğru yöntem -->
            // Murat ALTINPINAR
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12314";
            customer1.FirstName = "Murat";
            customer1.LastName = "Altınpınar";
            customer1.TCNumber = "41346134511";
            // Muboys Group
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "14121";
            customer2.CompanyName = "Muboys Group";
            customer2.TaxNumber = "4123561321";

            Customer customer3 = new Individual(); // Customer Sınıfı hem Individual classın referansını tutabilir.
            Customer customer4 = new Coorporate(); // Hemde Coorporate classının referansını tutabilir.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1); // Add fonksiyonu Customer classından bir değer istediği için
            customerManager.Add(customer2); // Miras aldığı classlarıda tutabiliriz.
            customerManager.Add(customer3); // Base sınıfı (Customer) referans tutucu olduğu için
            customerManager.Add(customer4); // Miras verdiği tüm classlarıda kullanabiliriz.

        }
    }
}
