using ChessGUI.enums;
using System;

namespace ChessGUI.MoveController
{
    class TargetOutSideHandler : MoveHandlerBase
    {
        public override void Handle(int x1, int y1, int x2, int y2, Field[,] fields)
        {
            if (!(x1 <= 7 && x1 >= 0 && y1 <= 7 && y2 >= 0 && x2 <= 7 && x2 >= 0 && y2 <= 7 && y2 >= 0))
            {
                Console.WriteLine(MovementResult.TARGET_OUTSIDE_BOARD);
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(x1, y1, x2, y2, fields);
            }
        }
    }
}
