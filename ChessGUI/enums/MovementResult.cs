namespace ChessGUI.enums
{
    public enum MovementResult
    {
        HIT,
        LEGAL_MOVE,
        NO_PIECE_ON_SOURCE,
        TARGET_OCCUPIED_BY_OWN_PIECE,
        TARGET_OUTSIDE_BOARD,
        ILLEGAL_MOVEMENT,
        COLLISION,
        NOT_ON_TURN
    }
}