namespace Chess.Contracts
{
    public interface IStateMachine
    {
        Dictionary<string, IState> States { get; }
        IState CurrentState { get; }
        public void ChangeState(string stateName);
        public void Update();
        public void AddState(string stateName, IState state);
        public void RemoveState(string stateName);
    }
    public interface IState
    {
        public void Enter();
        public void Exit();
        public void Update();
    }
}