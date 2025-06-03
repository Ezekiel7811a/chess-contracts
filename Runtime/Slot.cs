namespace Chess.Contracts
{
    public interface ISlot
    {
        int X { get; }
        int Y { get; }
        bool IsOccupied { get; }
        IPiece Piece { get; set; }
        event Action<IPiece> OnPiecePlaced;
        event Action<IPiece> OnPieceRemoved;
    }
}