using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHexStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string param = String.Empty;
            while (true)
            {
                Console.WriteLine("Enter number in hex number system or q for exit");
                param = Console.ReadLine();
                if (String.Equals(param, "q"))
                    break;

                if (param != null)
                {
                    try
                    {
                        num = Convert.ToInt32(param, 16);
                        Console.WriteLine("your nubmer in hex: 0x{0} converts to decimal: {1}.", param, num);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Unable to convert '0x{0}' to an unsigned integer.",param);
                    }
                    
                }
            }
            Console.WriteLine("Push any key to exit");
            Console.ReadLine();
        }
    }
}
