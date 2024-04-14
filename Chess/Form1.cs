using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class ChessForm : Form
    {
        public Cstm_Button[,] Buttons = new Cstm_Button[8, 8];
        public Board board = new Board();

        public ChessForm()
        {
            InitializeComponent();
            board = board.CreateNewBoard(new Cell[8, 8]);
            board.DrawBoard(board, this);
        }

        public ChessForm(ChessForm chess)
        {

        }
        public ChessForm GetChessForm()
        {
            return this;
        }

        public void SetForm(ChessForm chess)
        {
            Buttons = chess.Buttons;
            Text = "Setter";
            Show();
        }
    }
}
