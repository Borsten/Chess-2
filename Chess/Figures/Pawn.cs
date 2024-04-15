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

        public override List<Cell> CheckMove(Board board, Cell button)
        {
            List<Cell> cells = new List<Cell>();
            int move = 1;
            if (button.figure.color == "White")
                move = -1;
            if (board.cells[button.locY + move, button.locX].figure == null)
            {
                board.cells[button.locY + move, button.locX].bColor = Color.Yellow;
                cells.Add(board.cells[button.locY + move, button.locX]);
                if (board.cells[button.locY + move * 2, button.locX].figure == null)
                {
                    board.cells[button.locY + move * 2, button.locX].bColor = Color.Yellow;
                    cells.Add(board.cells[button.locY + move * 2, button.locX]);
                }
            }
            if (button.locX > 0 && board.cells[button.locY + move, button.locX - 1].figure != null)
            {
                if (board.cells[button.locY + move, button.locX - 1].figure.color != button.figure.color)
                {
                    board.cells[button.locY + move, button.locX - 1].bColor = Color.Red;
                    cells.Add(board.cells[button.locY + move, button.locX - 1]);
                }
            }
            if (button.locX < 7 && board.cells[button.locY + move, button.locX + 1].figure != null)
            {
                if (board.cells[button.locY + move, button.locX + 1].figure.color != button.figure.color)
                {
                    board.cells[button.locY + move, button.locX + 1].bColor = Color.Red;
                    cells.Add(board.cells[button.locY + move, button.locX + 1]);
                }
            }
            return cells;
        }
    }
}