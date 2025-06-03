namespace Chess.Contracts
{
    public interface IGameManager
    {
        private void Initialize() { }
        void StartGame();
        void TogglePauseGame();
        void EndGame();
        bool IsGameRunning { get; }
        event Action OnGameStarted;
        event Action OnGamePaused;
        event Action OnGameResumed;
        event Action OnGameEnded;
    }
}