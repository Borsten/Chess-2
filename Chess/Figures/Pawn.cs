using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Chess
{
    public class Pawn : Figure
    {
        public Pawn(string color) : base(color)
        {
            this.color = color;
        }

        public override List<Cell> CheckMove(Board board, Cstm_Button button)
        {
            List<Cell> cells = new List<Cell>();
            int move = 1;
            if (button.Cell.figure.color == "White")
                move = -1;
            if (board.cells[button.Cell.locY + move, button.Cell.locX].figure == null)
            {
                board.cells[button.Cell.locY + move, button.Cell.locX].bColor = Color.Yellow;
                cells.Add(board.cells[button.Cell.locY + move, button.Cell.locX]);
                if (board.cells[button.Cell.locY + move, button.Cell.locX].figure == null)
                {
                    board.cells[button.Cell.locY + move * 2, button.Cell.locX].bColor = Color.Yellow;
                    cells.Add(board.cells[button.Cell.locY + move * 2, button.Cell.locX]);
                }
            }
            if (button.Cell.locX > 0 && board.cells[button.Cell.locY + move, button.Cell.locX - 1].figure != null)
            {
                if (board.cells[button.Cell.locY + move, button.Cell.locX - 1].figure.color != button.Cell.figure.color)
                {
                    board.cells[button.Cell.locY + move, button.Cell.locX - 1].bColor = Color.Red;
                    cells.Add(board.cells[button.Cell.locY + move, button.Cell.locX - 1]);   
                }
            }
            if (button.Cell.locX < 7 && board.cells[button.Cell.locY + move, button.Cell.locX + 1].figure != null)
            {
                if (board.cells[button.Cell.locY + move, button.Cell.locX + 1].figure.color != button.Cell.figure.color)
                {
                    board.cells[button.Cell.locY + move, button.Cell.locX + 1].bColor = Color.Red;
                    cells.Add(board.cells[button.Cell.locY + move, button.Cell.locX + 1]);
                }
            }
            return cells;
        }
    }
}
