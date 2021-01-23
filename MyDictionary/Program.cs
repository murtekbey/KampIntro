using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Id = 1;
            person.Name = "Murat Altınpınar";
            PersonManager personManager = new PersonManager();
            personManager.Add(person);
        }
    }
}
