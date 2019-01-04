using ChessGUI.enums;
using System;

namespace ChessGUI.MoveController
{
    class TurnHandler : MoveHandlerBase
    {
        private static bool isFirst = true;
        public override void Handle(int x1, int y1, int x2, int y2, Field[,] fields)
        {
            if(fields[x1,y1].Piece.getColor == Colors.WHITE && isFirst)
            {
                isFirst = false;
            }

            if (isFirst && fields[x1,y1].Piece.getColor != Colors.WHITE)
            {
                MoveMessage.showMessage = MovementResult.NOT_ON_TURN.ToString();
            }
            else if (nextHandler != null)
            {   
                nextHandler.Handle(x1, y1, x2, y2, fields);
            }
        }
    }
}
