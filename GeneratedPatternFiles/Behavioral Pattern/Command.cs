namespace Namespace
{
    public interface ICommand
    {
        void Execute();
    }

    public class SimpleCommand : ICommand
    {
        private string payload;

        public SimpleCommand(string payload)
        {
            this.payload = payload;
        }

        public void Execute()
        {
            //TODO: Implement
        }
    }

    public class ComplexCommand : ICommand
    {
        private Receiver receiver;
        private type2 firstContextData;
        private type3 secondContextData;

        public ComplexCommand(Receiver receiver, type2 firstContextData, type3 secondContextData)
        {
            this.receiver = receiver;
            this.firstContextData = firstContextData;
            this.secondContextData = secondContextData;
        }

        public void Execute()
        {
            receiver.DoSomething(firstContextData);
            receiver.DoSomethingElse(secondContextData);
        }
    }

    public class Receiver
    {
        //TODO: Add core bussiness logic

        public void DoSomething(type2 firstContextData)
        {
            //TODO: Implement (uses firstContextData)
        }

        public void DoSomethingElse(type3 secondContextData)
        {
            //TODO: Implement (uses secondContextData)
        }
    }

    public class Invoker
    {
        private ICommand onStartCommand;
        private ICommand onFinishCommand;

        public void SetOnStartCommand(ICommand command)
        {
            onStartCommand = command;
        }

        public void SetOnFinishCommand(ICommand command)
        {
            onFinishCommand = command;
        }

        public void DoStuff()
        {
            onStartCommand?.Execute();

            //TODO: Implement operations of DoStuff to execute inbetween the commands

            onFinishCommand?.Execute();
        }
    }
}