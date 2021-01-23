using System;

namespace Constructor // yapıcı blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Murat", LastName="Altınpınar",City="Antalya" }; // default constructor çalışır

            Customer customer2 = new Customer ( 2,"Anıl","Koralay","Afyon" ); // parametre bekleyen constructor çalışır.

            Customer customer3 = new Customer(); // default constructor çalışır çünkü parametre göndermedik.
            customer3.Id = 3;

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer3.Id);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        // default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Constructor Working..");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
