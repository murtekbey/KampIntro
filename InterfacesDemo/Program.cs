using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eaters = new IEat[2] 
            {
                new Manager(),
                new Worker(),
            };
            foreach (var eater in eaters)
            {
                eater.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }

        interface IWorker
        {
            void Work();
        }
        // SOL(I)D, Interface Segregation
        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Manager is eating..");
            }

            public void GetSalary()
            {
                Console.WriteLine("Manager is getting salary..");
            }

            public void Work()
            {
                Console.WriteLine("Manager is working..");
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Worker is eating..");
            }

            public void GetSalary()
            {
                Console.WriteLine("Worker is getting salary..");
            }

            public void Work()
            {
                Console.WriteLine("Worker is working..");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot is working");
            }
        }
    }
}
