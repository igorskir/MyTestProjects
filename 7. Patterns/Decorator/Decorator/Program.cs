using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1.ToConsole();
            pizza1 = new TomatoPizza(pizza1);
            pizza1.ToConsole();

            Pizza pizza2 = new BulgerianPizza();
            pizza2.ToConsole();
            pizza2 = new CheesePizza(pizza2);
            pizza2.ToConsole();
            pizza2 = new TomatoPizza(pizza2);
            pizza2.ToConsole();

            Console.ReadLine();
        }
    }

    abstract class Pizza
    {
        public Pizza(string n)
        {
            Name = n;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
        public void ToConsole()
        {
            Console.WriteLine("Название: {0}, Цена: {1}", Name, GetCost());
        }
    }
    class ItalianPizza : Pizza
    {
        public ItalianPizza() 
            : base("Итальянская пицца")
        { }

        public override int GetCost()
        {
            return 10;
        }
    }
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Болгарская пицца")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza p) 
            :base(n)
        {
            pizza = p;
        }
    }

    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p)
            :base(p.Name + " с томатами", p)
        {

        }
        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }

    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza p)
            :base(p.Name + " с сыром", p)
        {

        }
        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }

}
