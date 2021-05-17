using System.Collections.Generic;

namespace Namespace
{
    public interface IObserver
    {
        void Update(IObservable Observable);
    }

    public interface IObservable
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }

    public class Observable : IObservable
    {
        public type valueToObserve;

        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            observers.ForEach(observer => observer.Update(this));
        }

        public void DoStuff()
        {
            //TODO: Implement
            NotifyObservers();
        }
    }

    public class FirstObserver : IObserver
    {
        public void Update(IObservable Observable)
        {
            //TODO: Implement (the reaction to a change in the observed object)
        }
    }

    public class SecondObserver : IObserver
    {
        public void Update(IObservable Observable)
        {
            //TODO: Implement (the reaction to a change in the observed object)
        }
    }
}