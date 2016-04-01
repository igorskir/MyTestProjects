using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent a = new PlainIceCream();
            IComponent b = new CandyTopping(a);
            IComponent c = new NutsTopping(b);
            c.AddTopping();

            Console.ReadLine();
        }
    }

    public interface IComponent
    {
        void AddTopping();
    }
    public class PlainIceCream : IComponent
    {
        public void AddTopping()
        {
            Console.WriteLine("Plain Ice Cream ready for some toppings");
        }
    }
    public abstract class Topping : IComponent
    {
        protected IComponent input;

        public Topping(IComponent i)
        {
            input = i;  //store the item to be decorated
        }

        public abstract void AddTopping();
    }
    public class CandyTopping : Topping, IComponent
    {
        public CandyTopping(IComponent iceCream)
            :base(iceCream)
        {

        }
        public override void AddTopping()
        {
            input.AddTopping();
            Console.WriteLine("Candy topping added");
        }
    }

    public class NutsTopping : Topping, IComponent
    {
        public NutsTopping(IComponent iceCream)
            :base(iceCream)
        {

        }
        public override void AddTopping()
        {
            input.AddTopping();
            Console.WriteLine("Nuts topping added");
        }
    }
}
