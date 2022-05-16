using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PDB_2
{
    public interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public interface IObserver
    {
        void Update();
    }
    public class ConcreteObserver : IObserver
    {
        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        private string name;
        public string Name
        {
            get => name;
        }

        public void Update()
        {
            Console.WriteLine(name + " is notified");
        }
    }
}
