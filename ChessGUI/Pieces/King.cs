using ChessGUI.enums;
using System;

namespace ChessGUI.Pieces
{
    public class King : Piece
    {
        public King(Colors color)
        {
            this.Colors = color;
            this.LetterDisplay = 'K';
        }

        public override bool LegalMove(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            if ((Math.Abs(dx) <= 1) || (Math.Abs(dx) <= 1))
            {
                HasBeenMoved = true;
                return true;
            }
            return false;
        }
    }
}
