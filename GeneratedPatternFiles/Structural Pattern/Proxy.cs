namespace Namespace
{
    public interface ISubject
    {
        void CommonMethod();
    }

    public class RealSubject : ISubject
    {
        public void CommonMethod()
        {
            //TODO: Implement
        }
    }

    public class Proxy : ISubject
    {
        private RealSubject realSubject;

        public Proxy(RealSubject realSubject)
        {
            this.realSubject = realSubject;
        }

        public void CommonMethod()
        {
            //TODO: Add additional logic before and/or after this
            realSubject.CommonMethod();
        }
    }
}