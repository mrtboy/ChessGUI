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

namespace ChessGUI
{
    public partial class chessControll : UserControl
    {
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
                        graphic.FillRectangle(myBrush, new Rectangle(j*80, i*80, 80, 80));
                       
                     
                        e.Graphics.DrawString(field.Piece.getColor == Colors.BLACK ? field.Piece.getLetterBlack.ToString() :
                        field.Piece.getLetterBlack.ToString(), new Font("Arial", 24), field.Piece.getColor == Colors.WHITE ? new
                        SolidBrush(Color.White) : new SolidBrush(Color.Black), new PointF(j * 80+18,
                        i * 80 + 20));
                       
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
                       

                    }
                  
                }
               
            }
           
            //myBrush.Dispose();
            //graphic.Dispose();
        }
    }
}
