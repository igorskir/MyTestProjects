using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();

            Func<string, int> d1 = helper.GetCount;
            Func<string, int> d2 = helper.GetCountSymbolA;

            string myMessage = "LAMP";

            Console.WriteLine("Count of letters in the string: {0}", DelegateTest(d1,myMessage) );
            Console.WriteLine("Count of letter 'A' in the string: {0}", DelegateTest(d2, myMessage));
            
            
            //Student vasa = new Student();

            //Action<string> method = Show;
            //vasa.Move(2,method);

            //vasa.Moving += vasa_Moving;

            

            //////////////////Comany , budget, salary//////////
            
            Company myComp = new Company(1000);
            
            myComp.ChangingSalary += MyCompOnChangingSalary;
            myComp.SetNewBudget(1000);

            Console.ReadLine();
        }

        private static void MyCompOnChangingSalary(object sender, SelaryEventArgs selaryEventArgs)
        {
            Employee newEmployee = new Employee(100);
            newEmployee.ChangeSelary(selaryEventArgs.SelaryDelta);
            Console.WriteLine("Omg, new Salary of out Employee is: {0}", newEmployee.Salary);
        }

        static void vasa_Moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }

        static int DelegateTest(Func<string,int> method, string message)
        {
            return method(message);
        }

    }
}
