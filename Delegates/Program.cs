using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            //MyDelegate myDelegate = customerManager.SendMessage;
            //myDelegate += customerManager.ShowAlert;
            //myDelegate -= customerManager.SendMessage;

            //myDelegate();

            //MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            //myDelegate2 += customerManager.ShowAlert2;

            //myDelegate2("Hello");

            //MyDelegate3 myDelegate3 = customerManager.Sum;
            //myDelegate3 += customerManager.Multiply;
            //Console.WriteLine(myDelegate3(5, 3));

            // -- Func -- //
            Func<int, int, int> add = Sum;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1000);
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }

        // Func
        static int Sum(int x, int y)
        {
            return x + y;
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
