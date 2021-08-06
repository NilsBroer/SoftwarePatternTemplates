using System.Collections.Generic;
using System.Linq;

namespace Namespace
{
    public class Flyweight
    {
        private SharedState sharedState;

        public Flyweight(SharedState sharedState)
        {
            this.sharedState = sharedState;
        }

        public void UseStates(UniqueState uniqueState)
        {
            //TODO: Use the two states as needed
        }
    }

    public class FlyweightFactory
    {
        private List<(Flyweight Flyweight, string Key)> flyweightCollection = new List<(Flyweight Flyweight, string Key)>();

        public FlyweightFactory(params SharedState[] args)
        {
            foreach (var state in args)
            {
                flyweightCollection.Add((new Flyweight(state), GetKey(state)));
            }
        }

        public Flyweight GetFlyweight(SharedState state)
        {
            var key = GetKey(state);

            if (flyweightCollection.Any(flyweightAndKey => flyweightAndKey.Key == key))
            {
                //Returning already existing flyweight
                return flyweightCollection.FirstOrDefault(flyweightAndKey => flyweightAndKey.Key == key).Flyweight;
            }

            //Creating new flyweight to return
            var flyweight = new Flyweight(state);
            flyweightCollection.Add((flyweight, GetKey(state)));

            return flyweight;
        }

        private string GetKey(SharedState state)
        {
            //TODO: Return a unique hash (string) using the values of the given state
            return hash;
        }
    }
}