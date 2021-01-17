using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " isimli kişi müşteri listenize eklendi.");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " isimli kişi müşteri listenizden silinmiştir.");
        }

        public void Get(Customer customer)
        {
            Console.WriteLine("Id: " + customer.Id + ", Ad: " + customer.Name + ", Soyad: " + customer.Surname);
        }
    }
}
