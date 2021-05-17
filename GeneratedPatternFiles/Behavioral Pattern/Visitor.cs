namespace Namespace
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

    public interface IVisitor
    {
        void Visit(FirstConcreteComponent firstConcreteComponent);
        void Visit(SecondConcreteComponent secondConcreteComponent);
    }

    public class FirstConcreteComponent : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void MethodExclusiveToTheFirstComponent()
        {
            //TODO: Implement
        }
    }

    public class SecondConcreteComponent : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void MethodExclusiveToTheSecondComponent()
        {
            //TODO: Implement
        }
    }

    public class FirstConcreteVisitor : IVisitor
    {
        public void Visit(FirstConcreteComponent firstConcreteComponent)
        {
            //TODO: Implement
        }

        public void Visit(SecondConcreteComponent secondConcreteComponent)
        {
            secondConcreteComponent.MethodExclusiveToTheSecondComponent();
            //TODO: Implement
        }
    }

    public class SecondConcreteVisitor : IVisitor
    {
        public void Visit(FirstConcreteComponent firstConcreteComponent)
        {
            //TODO: Implement
            firstConcreteComponent.MethodExclusiveToTheFirstComponent();
        }

        public void Visit(SecondConcreteComponent secondConcreteComponent)
        {
            //TODO: Implement
        }
    }
}