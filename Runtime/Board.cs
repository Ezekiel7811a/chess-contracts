namespace Chess.Contracts
{
    public interface IBoard
    {
        int Width { get; }
        int Height { get; }
        IPiece[,] Pieces { get; }

        void Initialize();
        void PlacePiece(IPiece piece, int x, int y);
        void RemovePiece(int x, int y);
        IPiece this[int x, int y] { get; }
        bool IsPositionValid(int x, int y);
        event Action<int, int> OnPieceMoved;
        event Action<int, int> OnPieceRemoved;
    }
}