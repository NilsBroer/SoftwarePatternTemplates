namespace Namespace
{
    public class Director
    {
        private IProductBuilder builder;

        public IProductBuilder Builder
        {
            set => builder = value;
        }

        public void BuildMinimalProduct()
        {
            builder.BuildFirstPart();
            builder.BuildSecondPart();
        }

        public void BuildProduct()
        {
            builder.BuildFirstPart();
            builder.BuildSecondPart();
            builder.BuildThirdPart();
        }
    }

    public interface IProductBuilder
    {
        public void Reset();
        public void BuildFirstPart();
        public void BuildSecondPart();
        public void BuildThirdPart();
    }

    public class FirstProductBuilder : IProductBuilder
    {
        private FirstProduct result;

        public void Reset()
        {
            this.result = new FirstProduct();
        }

        public void BuildFirstPart()
        {
            //TODO: Set the property FirstPart here
        }

        public void BuildSecondPart()
        {
            //TODO: Set the property SecondPart here
        }

        public void BuildThirdPart()
        {
            //TODO: Set the property ThirdPart here
        }

        public void Build()
        {
            BuildFirstPart();
            BuildSecondPart();
            BuildThirdPart();
        }

        public FirstProduct GetResult()
        {
            return this.result;
        }
    }

    public class SecondProductBuilder : IProductBuilder
    {
        private SecondProduct result;

        public void Reset()
        {
            this.result = new SecondProduct();
        }

        public void BuildFirstPart()
        {
            //TODO: Set the property FirstPart here
        }

        public void BuildSecondPart()
        {
            //TODO: Set the property SecondPart here
        }

        public void BuildThirdPart()
        {
            //TODO: Set the property ThirdPart here
        }

        public void Build()
        {
            BuildFirstPart();
            BuildSecondPart();
            BuildThirdPart();
        }

        public SecondProduct GetResult()
        {
            return this.result;
        }
    }

    public class FirstProduct
    {
        public TypeForFirstPartInFirstProduct FirstPart { get; set; }
        public TypeForSecondPartInFirstProduct SecondPart { get; set; }
        public TypeForThirdPartInFirstProduct ThirdPart { get; set; }
    }

    public class SecondProduct
    {
        public TypeForFirstPartInSecondProduct FirstPart { get; set; }
        public TypeForSecondPartInSecondProduct SecondPart { get; set; }
        public TypeForThirdPartInSecondProduct ThirdPart { get; set; }
    }
}