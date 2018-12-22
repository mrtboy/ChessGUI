using System;

namespace ChessGUI
{
    public static class DrawBoard
    {
        public static void drawTopLine()
        {
            draw("┌");
            for (int i = 0; i < 7; i++)
            {
                draw("─");
                draw("─");
                draw("─");
                draw("┬");
            }
            draw("─");
            draw("─");
            draw("─");
            draw("┐");
            nextLine();

        }

        public static void drawButtomLine()
        {
            draw("└");
            for (int i = 0; i < 7; i++)
            {
                draw("─");
                draw("─");
                draw("─");
                draw("┴");
            }
            draw("─");
            draw("─");
            draw("─");
            draw("┘");
            nextLine();
        }

        public static void drawMidLine()
        {
            draw("│");
        }
       public static void drawLine()
        {
            draw("├");
            for (int i = 0; i < 7; i++)
            {
                draw("─");
                draw("─");
                draw("─");
                draw("┼");
            }
            draw("─");
            draw("─");
            draw("─");
            draw("┤");
            nextLine();
        }

        public static void draw(string message, int spaces = 0)
        {
            Console.Write(message);
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
        }

        public static void nextLine()
        {
            Console.WriteLine();
        }


        public static void blackBackground()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void grayBackground()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }

        public static void redForeground()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void whiteForeground()
        {
            Console.ForegroundColor = ConsoleColor.White;
        } 
    }
}
