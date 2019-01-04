using ChessGUI.enums;
using System;

namespace ChessGUI.MoveController
{
    class LegalMoveHandler : MoveHandlerBase
    {
        public override void Handle(int x1, int y1, int x2, int y2, Field[,] fields)
        {
            if (fields[x1, y1].Piece.LegalMove(x1, y1, x2, y2))
            {
                fields[x2, y2].Piece = fields[x1, y1].Piece;
                fields[x1, y1].Piece = null;
                MoveMessage.showMessage = MovementResult.LEGAL_MOVE.ToString();
            } else
            {
                MoveMessage.showMessage = MovementResult.ILLEGAL_MOVEMENT.ToString();
            }
        }
    }
}
