using NUnit.Framework;
using PDB_2;
using System;

namespace CountdownTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorPositive()
        {
            Assert.DoesNotThrow(() => new Countdown(5));
        }

        [Test]
        public void ConstructorNegativeException()
        {
            Assert.Throws<ArgumentException> (() => new Countdown(-5));
        }

        [Test]
        public void AddObserver()
        {
            Countdown c = new Countdown(5);
            ConcreteObserver concreteObserver = new ConcreteObserver("");
            Assert.AreEqual(c.GetObserversSize(), 0);
            c.AddObserver(concreteObserver);
            Assert.AreEqual(c.GetObserversSize(), 1);
        }


        [Test]
        public void RemoveObserver()
        {
            Countdown c = new Countdown(5);
            ConcreteObserver concreteObserver = new ConcreteObserver("");
            c.AddObserver(concreteObserver);
            Assert.AreEqual(c.GetObserversSize(), 1);
            c.RemoveObserver(concreteObserver);
            Assert.AreEqual(c.GetObserversSize(), 0);
        }

        [Test]
        public void RemoveObserverAt()
        {
            Countdown c = new Countdown(5);
            c.AddObserver(new ConcreteObserver(""));
            Assert.AreEqual(c.GetObserversSize(), 1);
            c.RemoveObserverAt(0);
            Assert.AreEqual(c.GetObserversSize(), 0);
        }

        [Test]
        public void NotifyObservers()
        {
            Countdown c = new Countdown(5);
            c.AddObserver(new ConcreteObserver("a"));
            c.AddObserver(new ConcreteObserver("b"));
            Assert.DoesNotThrow(() => c.NotifyObservers());
        }

        [Test]
        public void StartCountdown()
        {
            Countdown c = new Countdown(5);
            c.AddObserver(new ConcreteObserver("a"));
            c.AddObserver(new ConcreteObserver("b"));
            Assert.DoesNotThrow(() => c.StartCountdown());
        }

    }
}