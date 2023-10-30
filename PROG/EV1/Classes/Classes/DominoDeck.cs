
namespace Classes
{
    public class DominoDeck
    {
        private List<DominoPiece> _pieceList = new List<DominoPiece>();

        public DominoPiece? ExtractPiece(int index)
        {
            
             var p = _pieceList[index];
            _pieceList.RemoveAt(index);
            return _pieceList[index];
        }
        public DominoPiece ExtractPiece()
        {
            int random = Utils.GetRandom(0, _pieceList.Count);
            return _pieceList[random];
        }
        public int GetPieceCount()
        {
            return _pieceList.Count;
        }
        public void AddPiece(DominoPiece piece)
        {
            if(piece == null)
                return;
            _pieceList.Add(piece);
        }
        public DominoPiece? GetPieceAt(int index)
        {
           return GetPieceAt(index);
        }
        public void Shuffle()
        {
            for(int i = 0; i < 500; i++)
            {
                int piece = Utils.GetRandom(0, _pieceList.Count);
                int piece2 = Utils.GetRandom(0, _pieceList.Count);

                int aux = piece;
                piece = piece2;
                piece2 = piece;
            }
        }
    }
}
