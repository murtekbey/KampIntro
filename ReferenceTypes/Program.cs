using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı 1: " + sayi1 );

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0]: " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Murat";

            person2 = person1;
            person1.FirstName = "Mustafa";

            // Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Anıl";
            customer.CreditCardNumber = "1231423";

            Employee employee = new Employee();
            employee.FirstName = "Bado";

            // customer = employee; // Bunları birbirine atayamazsın bunlar farklı tipler.

            Person person3 = customer; // Customer person classından miras aldığı için yapabilirsin.
            customer.FirstName = "Efe";
            // Console.WriteLine(person3.FirstName);

            // Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer); // Customer ve Employee, Person classından miras aldığı için 2 sinide kullanabiliriz.
            personManager.Add(employee);
            personManager.Add(person1);
        }
    }

    class Person // Temel Sınıf - base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    
    class PersonManager
    {
        public void Add(Person person) // Hem Customer, Hem Employee, Hem Person ile çalışabilirsin.
        {
            Console.WriteLine(person);
        }
    }
}
