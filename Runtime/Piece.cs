namespace Chess.Contracts
{
    public interface IPiece
    {
        string Name { get; }
        string Color { get; }
        int X { get; set; }
        int Y { get; set; }
        event Action<int, int> OnPositionChanged;
        event Action<IPiece> OnCaptured;

        void Move(int newX, int newY);
    }
}