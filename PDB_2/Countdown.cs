using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PDB_2
{
    public class Countdown : IObservable
    {
        private List<IObserver> observers;
        private int countTime;

        public int CountTime
        {
            get => countTime;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();  
                }
                this.countTime = value;
            }
        }


        public Countdown(int countTime)
        {
            this.observers = new List<IObserver>();
            this.CountTime = countTime;
        }

        public void RemoveObserverAt(int i)
        {
            observers.RemoveAt(i);
        }


        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }

        public void StartCountdown()
        {
            Thread.Sleep(this.countTime);
            NotifyObservers();
        }

        public int GetObserversSize()
        {
            return observers.Count();
        }
    }
}
