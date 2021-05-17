namespace Namespace
{
    public interface IComponent
    {
        public void BaseMethod();
    }

    public class BaseComponent : IComponent
    {
        public void BaseMethod()
        {
            //TODO: Implement
        }
    }

    public abstract class ComponentDecorator : IComponent
    {
        private IComponent baseComponent;

        public ComponentDecorator(IComponent baseComponent)
        {
            this.baseComponent = baseComponent;
        }

        public void SetBaseComponent(IComponent baseComponent)
        {
            this.baseComponent = baseComponent;
        }

        public virtual void BaseMethod()
        {
            baseComponent?.BaseMethod();
        }
    }

    public class FirstConcreteComponentDecorator : ComponentDecorator
    {
        public FirstConcreteComponentDecorator(IComponent baseComponent) : base(baseComponent)
        {

        }

        public override void BaseMethod()
        {
            //TODO: Implement
        }

        private void AnExtensionMethod()
        {
            base.BaseMethod();
            //TODO: Implement
        }
    }

    public class SecondConcreteComponentDecorator : ComponentDecorator
    {
        public SecondConcreteComponentDecorator(IComponent baseComponent) : base(baseComponent)
        {

        }

        private void AnotherExtensionMethod()
        {
            base.BaseMethod();
            //TODO: Implement
        }
    }
}