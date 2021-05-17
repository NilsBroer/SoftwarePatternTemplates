namespace Namespace
{
    public interface IPrototype
    {
        public IPrototype Clone();
    }

    public class ConcretePrototype : IPrototype
    {
        public type1 FirstProperty;
        private type2 secondProperty;
        private type3 thirdProperty;

        public ConcretePrototype(type1 firstProperty, type2 secondProperty, type3 thirdProperty)
        {
            this.FirstProperty = firstProperty;
            this.secondProperty = secondProperty;
            this.thirdProperty = thirdProperty;
        }

        internal ConcretePrototype(ConcretePrototype instance)
        {
            FirstProperty = instance.FirstProperty;
            secondProperty = instance.secondProperty;
            thirdProperty = instance.thirdProperty;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype(this);
        }
    }
}