using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RangeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            Console.WriteLine("X            Y         S");
            for (double i = 0; i < 1; i += 0.05)
            {
                y = 2*Math.Pow(Math.Cos(i), 2) - 1;

                Console.WriteLine(string.Format("{0:N3}      {1:N3}      0",i,y));
            }
            Console.ReadLine();
        }
    }
}
