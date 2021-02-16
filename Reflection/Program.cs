using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math math = new Math(2, 3);
            //Console.WriteLine(math.Sum(5, 4));
            //Console.WriteLine(math.Sum2()); 

            var type = typeof(Math);

            //Math math = (Math)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(math.Sum(4, 5));
            //Console.WriteLine(math.Sum2());

            var instance = Activator.CreateInstance(type, 6, 7);

            MethodInfo methodInfo = instance.GetType().GetMethod("Sum2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method adı: {0}", info.Name);
                foreach (var parameter in info.GetParameters())
                {
                    Console.WriteLine("Parameter: {0}", parameter.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
                }

                Console.WriteLine("----------------");
            }

            Console.ReadLine();
        }
    }

    public class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }

    public class Math
    {
        private int _number1;
        private int _number2;

        public Math(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Sum2()
        {
            return _number1 + _number2;
        }

        [MethodName("Çarpma işlemi")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }
}
