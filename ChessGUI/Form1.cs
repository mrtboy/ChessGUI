using ChessGUI.MoveController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ChessGUI
{
    public partial class Form1 : Form

    {
        private Board board = new Board();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = MoveMessage.showMessage;
        }

        private void chessControll1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = MoveMessage.showMessage;
        }

        public  void controllerIsRefreshed()
        {
            lblMessage.Text = MoveMessage.showMessage;

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            chessControll1.XmlSave();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chessControll1.XmlLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chessControll1.NewGame();
        }
    }
}
