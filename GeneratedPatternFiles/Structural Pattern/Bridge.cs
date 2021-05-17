namespace Namespace
{
    public interface IImplementation
    {
        public void DoBasicStuff();

        //TODO: Design the rest of the interface and implement it in the classes at the bottom
    }

    public class Abstraction
    {
        private IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public void DoBasicStuff()
        {
            implementation.DoBasicStuff();
        }

        //TODO: Add additional base functionalities
    }

    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {

        }

        //TODO: Add extended functionalities
    }

    public class FirstConcreteImplementation : IImplementation
    {
        public void DoBasicStuff()
        {
            //TODO: Implement
        }
    }

    public class SecondConcreteImplementation : IImplementation
    {
        public void DoBasicStuff()
        {
            //TODO: Implement
        }
    }
}