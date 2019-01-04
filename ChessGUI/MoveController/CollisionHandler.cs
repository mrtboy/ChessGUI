using ChessGUI.enums;
using ChessGUI.Pieces;
using System;

namespace ChessGUI.MoveController
{
    class CollisionHandler : MoveHandlerBase
    {
        public override void Handle(int x1, int y1, int x2, int y2, Field[,] fields)
        {
            if (!isPathFree(x1, y1, x2, y2, fields))
            {
                MoveMessage.showMessage =  MovementResult.COLLISION.ToString();
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(x1, y1, x2, y2, fields);
            }
        }

        private bool isPathFree(int x1, int y1, int x2, int y2, Field[,] Fields)
        {
            // Do not check knight
            if (Fields[x1, y1].Piece.GetType() == typeof(Knight))
            {
                return true;
            }

            if (x1 == x2 && y2 > y1)
            { // horizontal north
                for (int i = y2 - 1; i > y1; i--)
                {
                    if (Fields[i, x1].Piece != null)
                    {
                        return false;
                    }
                }
            }
            else if (x1 < x2 && y1 == y2)
            { // horizontal east
                for (int i = x1 + 1; i < x2; i++)
                {
                    if (Fields[y1, i].Piece != null)
                    {
                        return false;
                    }
                }
            }
            else if (x1 == x2 && y1 < y2)
            { // horizontal south
                for (int i = y1 + 1; i < y2; i++)
                {
                    if (Fields[i, x1].Piece != null)
                    {
                        return false;
                    }
                }
            }
            else if (x1 > x2 && y1 == y2)
            { // horizontal west
                for (int i = x1 - 1; i > x2; i--)
                {
                    if (Fields[y1, i].Piece != null)
                    {
                        return false;
                    }
                }
            }
            else if (x1 < x2 && y1 > y2)
            { // diagonal northeast
                for (int i = x2 - x1; i > 0; i--)
                {
                    if (Fields[x1 + i, y1 - i].Piece != null)
                    {
                        return false;
                    }
                }

            }
            else if (x1 < x2 && y1 < y2)
            { // diagonal southeast
                for (int row = x1 + 1; row < x2; row++)
                {
                    for (int col = y1 + 1; col < y2; col++)
                    {
                        if (Fields[row, col].Piece != null)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (x1 > x2 && y1 < y2)
            { // diagonal southwest
                for (int row = x1 - 1; row >= x2; row--)
                {
                    for (int col = y1 + 1; col < y2; col++)
                    {
                        if (Fields[row, col].Piece != null)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (x1 > x2 && y1 > y2)
            { // diagonal northwest
                for (int row = x1 - 1; row >= x2; row--)
                {
                    for (int col = y1 - 1; col >= y2; col--)
                    {
                        if (Fields[row, col].Piece != null)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
