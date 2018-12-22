using ChessGUI.enums;
using ChessGUI.Pieces;

namespace ChessGUI
{
    public class Field
    {
        public Piece Piece { get; set; }
        public Colors Color { get; set; }
        public Field()
        {
            this.Piece = null;
        }
        public bool IsOccupied()
        {
            return this.Piece != null;
        }

        public void drawChessField()
        {
            

        }
    }
}
