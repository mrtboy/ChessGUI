namespace ChessGUI.MoveController
{
    public abstract class MoveHandlerBase
    {
        protected MoveHandlerBase nextHandler;
        public abstract void Handle(int x1, int y1, int x2, int y2, Field[,] fields);

        public void SetNext(MoveHandlerBase nextHandler)
        {
            this.nextHandler = nextHandler;
        }
    }
}
