using ChessGUI.enums;
using System;

namespace ChessGUI.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Colors color)
        {
            this.Colors = color;
            this.LetterDisplayWhite = '♙';
            this.LetterDisplayBlack = '♟';
        }

        public override bool LegalMove(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            if (dy > 2)
            {
                return false;
            }

            if(HasBeenMoved != true)
            {
                if ((Math.Abs(dx) == 0) && ((Math.Abs(dy) == 1) || (Math.Abs(dy) == 2)))
                {
                    HasBeenMoved = true;
                    return true;
                }
            }
            else if(HasBeenMoved == true)
            {
                if ((Math.Abs(dx) == 0) && (Math.Abs(dy) == 1))
                {
                    HasBeenMoved = true;
                    return true;
                }
            }
            return false;
        }
    }
}
