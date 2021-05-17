namespace Namespace
{
    public interface ISummaryOfAllKindsFactory
    {
        public IProductOne ProduceProductOne();
        public IProductTwo ProduceProductTwo();
    }

    public class FirstKindOfProductFactory : ISummaryOfAllKindsFactory
    {
        public IProductOne ProduceProductOne()
        {
            return new FirstKindOfProductOne();
        }

        public IProductTwo ProduceProductTwo()
        {
            return new FirstKindOfProductTwo();
        }
    }

    public class SecondKindOfProductFactory : ISummaryOfAllKindsFactory
    {
        public IProductOne ProduceProductOne()
        {
            return new SecondKindOfProductOne();
        }

        public IProductTwo ProduceProductTwo()
        {
            return new SecondKindOfProductTwo();
        }
    }

    public class ThirdKindOfProductFactory : ISummaryOfAllKindsFactory
    {
        public IProductOne ProduceProductOne()
        {
            return new ThirdKindOfProductOne();
        }

        public IProductTwo ProduceProductTwo()
        {
            return null;
        }
    }

    public interface IProductOne
    {
        //TODO: Interface for all ProductOnes
    }

    public interface IProductTwo
    {
        //TODO: Interface for all ProductTwos
    }

    public class FirstKindOfProductOne : IProductOne
    {
        //TODO: Implement FirstKindOfProductOne
    }

    public class FirstKindOfProductTwo : IProductTwo
    {
        //TODO: Implement FirstKindOfProductTwo
    }

    public class SecondKindOfProductOne : IProductOne
    {
        //TODO: Implement SecondKindOfProductOne
    }

    public class SecondKindOfProductTwo : IProductTwo
    {
        //TODO: Implement SecondKindOfProductTwo
    }

    public class ThirdKindOfProductOne : IProductOne
    {
        //TODO: Implement ThirdKindOfProductTwo
    }
}