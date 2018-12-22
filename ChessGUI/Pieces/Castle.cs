using ChessGUI.enums;
using System;

namespace ChessGUI.Pieces
{
    public class Castle : Piece 
    {
        public Castle(Colors color)
        {
            this.Colors = color;
            this.LetterDisplay = 'C';
        }

        public override bool LegalMove(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            if ((Math.Abs(dy) == 0) || (Math.Abs(dx) == 0))
            {
                return true;
            }
            return false;
        }
    }
}
