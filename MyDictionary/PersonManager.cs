using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class PersonManager
    {
        public Dictionary<int, string> personDict = new Dictionary<int, string>();
        public void Add(Person person)
        {
            personDict.Add(person.Id, person.Name);

            foreach (KeyValuePair<int,string> i in personDict)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
