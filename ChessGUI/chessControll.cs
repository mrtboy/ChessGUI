using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGUI
{
    public partial class chessControll : UserControl
    {
        public chessControll()
        {
            InitializeComponent();
        }

        private void chessControll_Load(object sender, EventArgs e)
        {

        }

        private void chessControll_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(Color.Black);
            Graphics graphic;
            graphic = this.CreateGraphics();
            graphic.FillRectangle(myBrush, new Rectangle(2, 2, 50, 50));
            myBrush.Dispose();
            graphic.Dispose();
        }
    }
}
