using System;

namespace Namespace
{
    public interface IMediator
    {
        void Notify(object sender, EventCode eventCode);
    }

    public enum EventCode
    {
        A,
        B,
        C
    }

    public class BaseComponent
    {
        protected IMediator mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class FirstComponent : BaseComponent
    {
        public void MethodTriggeringA()
        {
            //TODO: Implement, then
            mediator.Notify(this, EventCode.A);
        }

        public void MethodTriggeredByC()
        {
            //TODO: Implement
        }
    }

    public class SecondComponent :
        BaseComponent
    {
        public void MethodTriggeringC()
        {
            //TODO: Implement, then
            mediator.Notify(this, EventCode.C);
        }

        public void MethodTriggeredByA()
        {
            //TODO: Implement
        }
    }

    public class Helper
    {
        public void HelperFunction()
        {
            //TODO: Implement
        }
    }

    public class TopicMediator : IMediator
    {
        private FirstComponent firstComponent;
        private SecondComponent secondComponent;
        private Helper helper;

        public TopicMediator(FirstComponent firstComponent, SecondComponent secondComponent)
        {
            this.firstComponent = firstComponent;
            this.secondComponent = secondComponent;
        }

        public void Notify(object sender, EventCode eventCode)
        {
            switch (eventCode)
            {
                case EventCode.A:
                    helper.HelperFunction();
                    secondComponent.MethodTriggeredByA();
                    break;
                case EventCode.B:
                    //TODO: Implement operation(s) for EventCode B
                    break;
                case EventCode.C:
                    helper.HelperFunction();
                    firstComponent.MethodTriggeredByC();
                    break;
                default:
                    throw new ArgumentException($"Unknown EventCode: {nameof(eventCode)}", nameof(eventCode));
            }
        }
    }
}