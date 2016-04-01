using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("ЮнитБанк", stock);
            Broker broker = new Broker("Иван Иваныч", stock);
            // имитация торгов
            stock.Market();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            stock.Market();

            Console.Read();
        }
    }

    #region Interfaces

    interface IObserver
    {
        void Update(Object ob);
    }

    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    #endregion


    class Stock : IObservable
    {
        private StockInfo sInfo;
        private List<IObserver> _observers;

        public Stock()
        {
            _observers = new List<IObserver>();
            sInfo = new StockInfo();
        } 
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(sInfo);
            }
        }

        public void Market()
        {
            Random rnd =new Random();
            sInfo.USD = rnd.Next(20, 40);
            sInfo.Euro = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
    class StockInfo
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }

    class Broker : IObserver
    {
        private IObservable _stock;

        public Broker(string name, IObservable obs)
        {
            Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }

        public string Name { get; set; }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo) ob;

            if (sInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
        }
        public void StopTrade()
        {
            _stock.RemoveObserver(this);
            _stock = null;
        }
    }

    class Bank : IObserver
    {
        private IObservable _stock;

        public Bank(string name, IObservable obs)
        {
            Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }

        public string Name { get; set; }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }
    }
}
