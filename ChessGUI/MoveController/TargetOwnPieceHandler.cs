using ChessGUI.enums;
using System;

namespace ChessGUI.MoveController
{
    class TargetOwnPieceHandler : MoveHandlerBase
    {
        public override void Handle(int x1, int y1, int x2, int y2, Field[,] fields)
        {
            if(fields[x2, y2].Piece!= null)
            {
                if (fields[x1, y1].Piece.getColor == fields[x2, y2].Piece.getColor)
                {
                    Console.WriteLine(MovementResult.TARGET_OCCUPIED_BY_OWN_PIECE);
                }
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(x1, y1, x2, y2, fields);
            }
        }
    }
}
