using System;

namespace Namespace
{
    public class Context
    {
        private IStrategy strategy;

        public Context()
        {

        }

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public resultType DoStuff(inputype data)
        {
            var result = strategy.DoStrategySpecificStuff(data);

            return result;
        }
    }

    public interface IStrategy
    {
        resultType DoStrategySpecificStuff(inputype data);
    }

    public class FirstConcreteStrategy : IStrategy
    {
        public resultType DoStrategySpecificStuff(inputype data)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }

    public class SecondConcreteStrategy : IStrategy
    {
        public resultType DoStrategySpecificStuff(inputype data)
        {
            //TODO: Implement
            throw new NotImplementedException();
        }
    }
}