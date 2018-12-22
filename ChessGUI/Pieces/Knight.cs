using ChessGUI.enums;
using System;

namespace ChessGUI.Pieces
{
    public class Knight : Piece
    {
        public Knight(Colors color)
        {
            this.Colors = color;
            this.LetterDisplay = 'K';
        }

        public override bool LegalMove(int x1, int y1, int x2 , int y2)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            
            bool isLegal = (dx == 1 && dy == 2) || (dx == 2 && dy == 1);

            return isLegal;
        }
    }
}
