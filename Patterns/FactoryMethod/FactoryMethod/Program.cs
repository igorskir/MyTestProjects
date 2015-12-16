using System;
using System.Threading;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("TDSK_PANEL");
            House panelHouse = dev.Create();

            dev = new WoodDeveloper("WOOD_STROY");
            House woodHouse = dev.Create();

            Console.ReadLine();
        }
    }


    #region Developer Classes
    internal abstract class Developer
    {
        public Developer(string n)
        {
            Name = n;
        }

        public string Name { get; set; }

        // Fabric method
        public abstract House Create();
    }

    internal class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n)
            : base(n)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }

    internal class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n)
            : base(n)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    } 
    #endregion

    internal abstract class House
    {
    }

    internal class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }

    internal class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}