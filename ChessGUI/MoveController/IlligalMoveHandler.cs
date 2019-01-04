using ChessGUI.enums;
using ChessGUI.Pieces;
using System;

namespace ChessGUI.MoveController
{
    class IlligalMoveHandler : MoveHandlerBase
    {
        public override void Handle(int x1, int y1, int x2, int y2, Field[,] fields)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            if (fields[x1, y1].Piece.GetType() == typeof(Pawn) && fields[x2, y2].Piece != null)
            {
                MoveMessage.showMessage =MovementResult.ILLEGAL_MOVEMENT.ToString();
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(x1, y1, x2, y2, fields);
            }
        }
    }
}
