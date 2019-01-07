using ChessGUI.MoveController;
using ChessGUI.enums;
using ChessGUI.Pieces;
using System.Xml.Serialization;

namespace ChessGUI
{
    public class Board
    {
        [XmlIgnore]
        public Field[,] Fields { get; set; }

        public Board()
        {
            this.Fields = new Field[8, 8];
            ColorTheBoard();
            InitFillTheBorad(Colors.BLACK, Colors.WHITE);
        }
        public Field[] SerFields
        {
            get
            {
                Field[] serFields = new Field[64];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        serFields[i + j * 8] = Fields[i, j];
                    }
                }
                return serFields;
            }
            set
            {
                Field[] serFields = value;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Fields[i, j] = serFields[i + j * 8];
                    }
                }
            }
        }

       public  void ColorTheBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Fields[i, j] = new Field();
                    if ((j + i) % 2 == 0)
                    {
                        Fields[i, j].Color = Colors.GRAY;
                    }
                    else
                    {
                        Fields[i, j].Color = Colors.BLACK;
                    }
                }
            }
        }

        public void InitFillTheBorad(Colors upColor, Colors downColor)
        {
            for (int i = 0; i < 8; i++)
            {
                Fields[i, 0].Piece = this.handlePiecePosition(i, upColor);
                Fields[i, 1].Piece = this.handlePiecePosition(8, upColor);

                Fields[i, 6].Piece = this.handlePiecePosition(8, downColor);
                Fields[i, 7].Piece = this.handlePiecePosition(i, downColor);
            }

        }
        private Piece handlePiecePosition(int position, Colors color)
        {
            switch (position)
            {
                case 0:
                    return new Castle(color);
                case 1:
                    return new Knight(color);
                case 2:
                    return new Bishop(color);
                case 3:
                    return new Queen(color);
                case 4:
                    return new King(color);
                case 5:
                    return new Bishop(color);
                case 6:
                    return new Knight(color);
                case 7:
                    return new Castle(color);
                default:
                    return new Pawn(color);
            }
        }

        

        public void move(int x1, int y1, int x2, int y2)
        {
            // Chain and Responsibility Design Pattern
            MoveHandlerBase targetOutside = new TargetOutSideHandler();
            MoveHandlerBase noPieceOnSource = new NoPieceOnSourceHandler();
            MoveHandlerBase turn = new TurnHandler();
            MoveHandlerBase targetOwnPiece = new TargetOwnPieceHandler();
            MoveHandlerBase collision = new CollisionHandler();
            MoveHandlerBase illigalMove = new IlligalMoveHandler();
            MoveHandlerBase hit = new HitHandler();
            MoveHandlerBase legalMove = new LegalMoveHandler();


            targetOutside.SetNext(noPieceOnSource);
            noPieceOnSource.SetNext(turn);
            turn.SetNext(targetOwnPiece);
            targetOwnPiece.SetNext(collision);
            collision.SetNext(illigalMove);
            illigalMove.SetNext(hit);
            hit.SetNext(legalMove);


            targetOutside.Handle(x1, y1, x2, y2, Fields);

        }
    }
}
