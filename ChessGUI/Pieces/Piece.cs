using ChessGUI.enums;
using System.Xml.Serialization;

namespace ChessGUI.Pieces
{

    [System.Serializable]
    [XmlInclude(typeof(Piece))]
    [XmlInclude(typeof(Bishop))]
    [XmlInclude(typeof(Castle))]
    [XmlInclude(typeof(King))]
    [XmlInclude(typeof(Knight))]
    [XmlInclude(typeof(Pawn))]
    [XmlInclude(typeof(Queen))]
    public abstract class Piece
    {
        public char LetterDisplayWhite { get; set; }
        public char LetterDisplayBlack { get; set; }
        public Colors Colors { get; set; }
        public bool HasBeenMoved { get; set; }

        public char getLetterWhite
        {
            get
            {
                return LetterDisplayWhite;
            }
        }
        public char getLetterBlack
        {
            get
            {
                return LetterDisplayBlack;
            }
        }
        public Colors getColor
        {
            get
            {
                return Colors;
            }
        }

        public abstract bool LegalMove(int x1, int y1, int x2, int y2);
    }
    
}
