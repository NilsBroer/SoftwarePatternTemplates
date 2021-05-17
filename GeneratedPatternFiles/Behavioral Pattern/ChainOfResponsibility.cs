namespace Namespace
{
    public interface IHandler
    {
        IHandler SetNextHandler(IHandler nextHandler);

        object Handle(object request);
    }

    public abstract class Handler : IHandler
    {
        private IHandler nextHandler;

        public IHandler SetNextHandler(IHandler nextHandler)
        {
            this.nextHandler = nextHandler;
            return nextHandler;
        }

        public virtual object Handle(object request)
        {
            return nextHandler?.Handle(request);
        }

        protected virtual bool canHandle(object request)
        {
            return false;
        }
    }

    public class FirstConcreteHandler : Handler
    {
        public override object Handle(object request)
        {
            if (canHandle(request))
            {
                //TODO: Implement handling
            }

            return base.Handle(request);
        }

        protected override bool canHandle(object request)
        {
            //TODO: Implement
            return base.canHandle(request);
        }
    }

    public class SecondConcreteHandler : Handler
    {
        public override object Handle(object request)
        {
            if (canHandle(request))
            {
                //TODO: Implement handling
            }

            return base.Handle(request);
        }

        protected override bool canHandle(object request)
        {
            //TODO: Implement
            return base.canHandle(request);
        }
    }

    public class ThirdConcreteHandler : Handler
    {
        public override object Handle(object request)
        {
            if (canHandle(request))
            {
                //TODO: Implement handling
            }

            return base.Handle(request);
        }

        protected override bool canHandle(object request)
        {
            //TODO: Implement
            return base.canHandle(request);
        }
    }
}