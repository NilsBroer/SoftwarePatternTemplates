namespace Namespace
{
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public void Transition(State state)
        {
            this.state = state;
            this.state.SetContext(this);
        }

        public void FirstRequest()
        {
            state.HandleFirstRequest();
        }

        public void SecondRequest()
        {
            state.HandleSecondRequest();
        }
    }

    public abstract class State
    {
        private Context context;

        public void SetContext(Context context)
        {
            this.context = context;
        }

        public abstract void HandleFirstRequest();
        public abstract void HandleSecondRequest();
    }

    public class FirstConcreteState : State
    {
        public override void HandleFirstRequest()
        {
            //TODO: Implement
        }

        public override void HandleSecondRequest()
        {
            //TODO: Implement
        }
    }

    public class SecondConcreteState : State
    {
        public override void HandleFirstRequest()
        {
            //TODO: Implement
        }

        public override void HandleSecondRequest()
        {
            //TODO: Implement
        }
    }
}