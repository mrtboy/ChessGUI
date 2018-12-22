using ChessGUI.enums;


namespace ChessGUI.Pieces
{
    public abstract class Piece
    {
        protected char LetterDisplay { get; set; }
        protected Colors Colors { get; set; }
        protected bool HasBeenMoved { get; set; }

        public char getLetter
        {
            get
            {
                return LetterDisplay;
            }
        }
        public Colors getColor
        {
            get
            {
                return Colors;
            }
        }

        public abstract bool LegalMove(int x1, int y1, int x2, int y2);
    }
    
}
