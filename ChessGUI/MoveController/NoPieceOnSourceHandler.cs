using ChessGUI.enums;
using System;

namespace ChessGUI.MoveController
{
    class NoPieceOnSourceHandler : MoveHandlerBase
    {
        public override void Handle(int x1, int y1, int x2, int y2, Field[,] fields)
        {
            if (fields[x1, y1].Piece == null)
            {
                MoveMessage.showMessage = MovementResult.NO_PIECE_ON_SOURCE.ToString();
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(x1, y1, x2, y2, fields);
            }
        }
    }
}
