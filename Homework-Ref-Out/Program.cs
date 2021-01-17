using System;

namespace Homework_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2); // number1 referans tip olarak gönderildiği için artık number1 = 30
            Console.WriteLine(result2); // fonksiyon içerisinde number1 30 olarak belirlendiği için result2 = 130
            Console.WriteLine(number1); // eğer referans tip olarak gönderilmeseydi number1=20, referans tip olarak gönderildiği için number1=30

            int number3; // outda değer atamadan gönderebilirsiniz fakat ref de gönderemezsiniz.
            int number4 = 100;
            var result3 = Add4(out number3, number4); // out ile değer göndermeden önce number3 'ün fonksiyon içerisinde tanımlanması gerekir.
            Console.WriteLine(result3); // number3 değerini fonksiyon içerisinde 30 olarak tanımladık o yüzden sonuç 130
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added !!");
        }

        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2) // number1'i referans tip olarak gönderdik.
        {
            number1 = 30; // number1 değerini 30 olarak değiştirdik. referans tip olduğu için dışarıya da yansıması 30 oldu.
            return number1 + number2;
        }

        static int Add4(out int number3, int number4)
        {
            number3 = 30;
            return number3 + number4;
        }
    }
}
