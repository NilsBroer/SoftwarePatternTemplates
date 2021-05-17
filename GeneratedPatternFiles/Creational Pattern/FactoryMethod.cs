namespace Namespace
{
    public abstract class BaseProduct
    {
        public void CoreProductLogic()
        {
            //TODO: Implement CoreProductLogic
        }
    }

    public abstract class BaseProductCreator
    {
        public abstract BaseProduct Create();

        public void CoreBusinessLogic()
        {
            //TODO: Implement CoreBusinessLogic
        }
    }

    public class FirstConcreteProductCreator : BaseProductCreator
    {
        public override BaseProduct Create()
        {
            var result = new FirstConcreteProduct();
            CoreBusinessLogic();
            result.CoreProductLogic();
            return result;
        }
    }

    public class SecondConcreteProductCreator : BaseProductCreator
    {
        public override BaseProduct Create()
        {
            var result = new SecondConcreteProduct();
            CoreBusinessLogic();
            result.CoreProductLogic();
            return result;
        }
    }

    public class FirstConcreteProduct : BaseProduct
    {
        //TODO: Implementation specifically for FirstConcreteProduct
    }

    public class SecondConcreteProduct : BaseProduct
    {
        //TODO: Implementation specifically for SecondConcreteProduct
    }
}