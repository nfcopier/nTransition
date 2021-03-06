using System;

namespace nTransition
{
    public class StateMachine<TInput, TState> : TransitionMachine<TState> where TState : IComparable where TInput : IComparable
    {
        
        public StateMachine(Action<StateTransitionBuilder<TInput, TState>> action)
        {
            var builder = new StateTransitionBuilder<TInput, TState>();
            action(builder);
        }

        public StateMachine(TransitionConfiguration<TState> config) : base(config)
        {
            this.Configuration = config;
        }
    }
}
