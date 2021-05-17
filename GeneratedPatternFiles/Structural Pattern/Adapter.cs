namespace Namespace
{
    public interface IDomainObject
    {
        //TODO: Design the DomainObject interface
    }

    public class DomainObjectAdapter : IDomainObject
    {
        private readonly Adaptee adaptee;

        public DomainObjectAdapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        //TODO: Use the functionalities of the adaptee in a way that is compatible with resources requiring the DomainObject interface
    }
}