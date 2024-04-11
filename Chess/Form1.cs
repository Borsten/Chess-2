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
        public List<Cstm_Button> Buttons = new List<Cstm_Button>();
        public static Board board = new Board();

        public ChessForm()
        {
            InitializeComponent();
            board = board.CreateNewBoard(new Cell[8, 8]);
            board.DrawBoard(board, this);
        }
    }
}
