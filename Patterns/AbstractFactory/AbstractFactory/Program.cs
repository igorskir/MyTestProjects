using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Run();
            elf.Hit();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.Hit();
            warrior.Run();

            Console.ReadLine();
        }
    }

    public abstract class Weapon
    {
        public abstract void Hit();
    }

    public abstract class Movement
    {
        public abstract void Move();
    }

    public class Crossbow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляю из арбалета!");
        }
    }

    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бью мечем");
        }
    }

    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Я лечу! Лечуууу!");
        }
    }

    public class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Я бегууу!");
        }
    }

    public abstract class HeroesFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }

    public class ElfFactory : HeroesFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Crossbow();
        }
    }

    public class WarriorFactory : HeroesFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }

    public class Hero
    {
        private Weapon _weapon;
        private Movement _movement;

        public Hero(HeroesFactory heroesFactory)
        {
            _weapon = heroesFactory.CreateWeapon();
            _movement = heroesFactory.CreateMovement();
        }

        public void Run()
        {
            _movement.Move();
        }

        public void Hit()
        {
            _weapon.Hit();
        }
    }
}
