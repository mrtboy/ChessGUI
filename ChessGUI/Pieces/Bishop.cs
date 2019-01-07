using ChessGUI.enums;
using System;


namespace ChessGUI.Pieces
{
    public class Bishop : Piece
    {

        public Bishop(Colors color)
        {
            this.Colors = color;
            this.LetterDisplayWhite = '♗';
            this.LetterDisplayBlack = '♝';
        }
        public Bishop()
        {

        }
        public override bool LegalMove(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            if (Math.Abs(dx) == Math.Abs(dy))
            {
                return true;
            }
            return false;
        }
    }
}
