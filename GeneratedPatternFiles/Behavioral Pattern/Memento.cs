using System;
using System.Collections.Generic;
using System.Linq;

namespace Namespace
{
    public class Originator
    {
        private State state;

        public Originator(State state)
        {
            this.state = state;
        }

        public void DoSomething()
        {
            //TODO: Implement the actual functionality of this class
            this.state = new State(this);
        }

        public IMemento Save()
        {
            return new OriginatorMemento(state);
        }

        public bool Restore(IMemento memento)
        {
            if (!(memento is OriginatorMemento)) return false;

            state = memento.GetState();
            return true;
        }
    }

    public class State
    {
        public State(Originator originator)
        {
            //TODO: Implement the way a state should be created depending on the originator
        }
    }

    public interface IMemento
    {
        string GetIdentifier();
        State GetState();
        DateTime GetDateTime();
    }

    public class OriginatorMemento : IMemento
    {
        private State state;
        private DateTime dateTime;

        public OriginatorMemento(State state)
        {
            this.state = state;
            dateTime = DateTime.Now;
        }

        public string GetIdentifier()
        {
            //TODO: Implement the way by which mementos get identified
            return "Unidentified Momento";
        }

        public State GetState()
        {
            return state;
        }

        public DateTime GetDateTime()
        {
            return dateTime;
        }
    }

    public class OriginatorCaretaker
    {
        private List<IMemento> mementos = new List<IMemento>();

        private Originator originator;

        public OriginatorCaretaker(Originator originator)
        {
            this.originator = originator;
        }

        public void Backup()
        {
            mementos.Add(originator.Save());
        }

        public void Undo()
        {
            if (!mementos.Any()) return;

            var memento = mementos.Last();
            mementos.Remove(memento);

            while (!originator.Restore(memento))
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            mementos.ForEach(memento => Console.WriteLine($"{memento.GetDateTime()} - {memento.GetIdentifier()}"));
        }
    }
}