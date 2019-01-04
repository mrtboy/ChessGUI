using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessGUI.enums;
using ChessGUI.Pieces;

namespace ChessGUI
{
    public partial class chessControll : UserControl
    {
        static int X = -1;
        static int Y = -1;
        static int[] selectedField = new int[3];
        static bool isMove = false;
        private Board board = new Board();
        public chessControll()
        {
            InitializeComponent();
        }

        private void chessControll_Load(object sender, EventArgs e)
        {

        }

        private void chessControll_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush myBrush;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    var field = board.Fields[j, i];
                    if (field.IsOccupied())
                    {
                        int x = j * 80;
                        int y = i * 80;
                        int nextX = (j + 1) * 80;
                        int nextY = (i + 1) * 80;
                        bool isXInRange = x < X && X < nextX;
                        bool isYInRange = y < Y && Y < nextY;
                        
                        if (isXInRange && isYInRange && isMove)
                        {
                            myBrush = new SolidBrush(Color.Green);
                            selectedField[0] = i;
                            selectedField[1] = j;
                        } else
                        {
                            if (field.Color == Colors.GRAY)
                            {
                                myBrush = new SolidBrush(Color.LightGray);

                            }
                            else
                            {
                                myBrush = new SolidBrush(Color.DarkGray);
                            }
                        }

                        Graphics graphic;
                        graphic = this.CreateGraphics();
                        graphic.FillRectangle(myBrush, new Rectangle(j*80, i*80, 80, 80));
                        
                        e.Graphics.DrawString(field.Piece.getColor == Colors.BLACK ? field.Piece.getLetterBlack.ToString() :
                        field.Piece.getLetterBlack.ToString(), new Font("Arial", 40), field.Piece.getColor == Colors.WHITE ? new
                        SolidBrush(Color.White) : new SolidBrush(Color.Black), new PointF(j * 80, i * 80 + 20));
                        graphic.Dispose();
                    }
                    else
                    {
                        if (field.Color == Colors.GRAY)
                        {
                            myBrush = new SolidBrush(Color.LightGray);

                        }
                        else
                        {
                            myBrush = new SolidBrush(Color.DarkGray);
                        }
                        
                        Graphics graphic;
                        graphic = this.CreateGraphics();
                        graphic.FillRectangle(myBrush, new Rectangle(j * 80, i*80, 80, 80));
                        graphic.Dispose();

                    }
                    myBrush.Dispose();
                }
            }
        }

        private void chessControll_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            if (isMove)
            {
                int[] target = new int[2];
                target = findSelectedField();
                int x1 = selectedField[1];
                int y1 = selectedField[0];
                int x2 = target[1];
                int y2 = target[0];
                board.move(x1, y1, x2, y2);
                Form1 form1 = new Form1();
                form1.controllerIsRefreshed();
                isMove = false;
            } else
            {
                isMove = true;
            }
            this.Refresh();
         
        }

        private int[] findSelectedField()
        {
            int[] target = new int[2];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var field = board.Fields[j, i];
                    int x = j * 80;
                    int y = i * 80;
                    int nextX = (j + 1) * 80;
                    int nextY = (i + 1) * 80;
                    bool isXInRange = x < X && X < nextX;
                    bool isYInRange = y < Y && Y < nextY;

                    if (isXInRange && isYInRange)
                    {
                        target[0] = i;
                        target[1] = j;
                    }
                }
            }
            return target;
        }
    }
}
