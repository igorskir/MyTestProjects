using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывести пользователю простое сообщение.
            SideEffect();

            int i = 1;
            int x = 10;
            int a = x + ++x;
            x = 10;
            int b = ++x + x;
            Console.WriteLine("a = {0}, b = {1}",a,b);

            Console.WriteLine(++i);
            Console.WriteLine(i++);
            Console.WriteLine(i);


            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            // Ожидать нажатия клавиши <Enter> перед завершением работы.
            Console.ReadLine();
        }

        static public int F(ref int asd )
        {
           return asd = 5;
        }
        static public void SideEffect()
        {
            int a = 0, b = 0, c = 0;
            a = 1; b = a + F(ref a);
            a = 1; c = F(ref a) + a;
            Console.WriteLine("a ={0}, b ={1}, c ={2}",a, b, c);
        }

    }
}
