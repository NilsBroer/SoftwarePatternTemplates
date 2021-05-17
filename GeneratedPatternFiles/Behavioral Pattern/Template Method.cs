namespace Namespace
{
    public abstract class AbstractClass
    {
        protected void FirstBaseOperation()
        {
            //TODO: Implement
        }

        protected void SecondBaseOperation()
        {
            //TODO: Implement
        }

        protected virtual void OverridableOperation()
        {
            //TODO: Implement
        }

        protected virtual void FirstOptionalOperation()
        {
        }

        protected virtual void SecondOptionalOperation()
        {
        }

        protected abstract void FirstRequiredOperation();

        protected abstract void SecondRequiredOperation();

        public void TemplateMethod()
        {
            FirstBaseOperation();
            FirstRequiredOperation();
            SecondBaseOperation();
            FirstOptionalOperation();
            SecondRequiredOperation();
            OverridableOperation();
            SecondOptionalOperation();
        }

    }

    public class FirstConcreteClass : AbstractClass
    {
        protected override void FirstRequiredOperation()
        {
            //TODO: Implement
        }

        protected override void SecondRequiredOperation()
        {
            //TODO: Implement
        }
    }

    public class SecondConcreteClass : AbstractClass
    {
        protected override void FirstRequiredOperation()
        {
            //TODO: Implement
        }

        protected override void SecondRequiredOperation()
        {
            //TODO: Implement
        }

        protected override void OverridableOperation()
        {
            //TODO: Implement (or remove)
        }

        protected override void FirstOptionalOperation()
        {
            //TODO: Implement (or remove)
        }
    }
}