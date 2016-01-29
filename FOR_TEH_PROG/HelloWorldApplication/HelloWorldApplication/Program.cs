using System;

namespace HelloWorldApplication
{
    internal class Program
    {
        private static void myCh(ref char c)
        {
            c = 'A';
        }

        // Метод меняющий местами аргументы
        private static void Swap(ref char a, ref char b)
        {
            char temp;
            temp = a;
            a = b;
            b = temp;
        }

        // a = 10; b = 20;
        //private static int TestRef(ref int a, int b)
        //{
        //    a = b; // a = 20;
        //    a++; // a = 21;
        //    b++;
        //    return b; // b = 21;
        //}


        //Метод возвращающий целую и дробную части
        // числа, квадрат и корень числа
        // d = 12.897
        //private static int TrNumber(double d, out double dr, out double sqr, out double sqrt)
        //{
        //    var i = (int) d;
        //    dr = d - i;
        //    sqr = d*d;
        //    sqrt = Math.Sqrt(d);

        //    return i;
        //}

        //static void TestParams(params int[] args)
        //{

        //}


        //Рекурсивный метод
        static int factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = factorial(i - 1) * i;
            return result;
        }


        private static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //b = TestRef(ref a, b);
            //Console.WriteLine("a:{0}, b:{1}", a,b);

            //char ch = 'B';
            //Console.WriteLine("Переменная ch до вызова метода myCh: {0}", ch);
            //myCh(ref ch);
            //Console.WriteLine("Переменная ch после вызова метода myCh: {0}", ch);


            //char s1 = 'D', s2 = 'F';
            //Console.WriteLine("\nПеременная s1 = {0}, переменная s2 = {1}", s1, s2);
            //Swap(ref s1, ref s2);
            //Console.WriteLine("Теперь s1 = {0}, s2 = {1}", s1, s2);
            //Console.ReadLine();

            //int i;
            //double myDr, mySqr, mySqrt;
            //var myD = 12.987;
            //i = TrNumber(myD, out myDr, out mySqr, out mySqrt);

            //Console.WriteLine(
            //    "Исходное число: {0}\nЦелая часть числа: {1}\nДробная часть числа: {2}\nКвадрат числа: {3}\nКвадратный корень числа: {4}",
            //    myD, i, myDr, mySqr, mySqrt);

            //Console.ReadLine();

            //TestParams(1,2);
            //TestParams(1,2,4,5,6,6,7);

            Console.WriteLine("Введите число: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}! = {1}", i, factorial(i));
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректное число");

            }

            Console.ReadLine();
        }
    }
}