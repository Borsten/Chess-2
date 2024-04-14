using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Queen : Figure 
    {
        public Queen(string color) : base(color)
        {
            this.color = color;
        }
        public override List<Cell> CheckMove(Board board, Cstm_Button button)
        {
            int i;
            List<Cell> cells = new List<Cell>();
            for (i = 1; button.Cell.locY + i < 8 && button.Cell.locX + i < 8; i++)
            {
                if (board.cells[button.Cell.locY + i, button.Cell.locX + i].figure == null)
                {
                    board.cells[button.Cell.locY + i, button.Cell.locX + i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.Cell.locY + i, button.Cell.locX + i]);
                }
                else if (board.cells[button.Cell.locY + i, button.Cell.locX + i].figure != null)
                {
                    if (board.cells[button.Cell.locY + i, button.Cell.locX + i].figure.color != button.Cell.figure.color)
                    {
                        board.cells[button.Cell.locY + i, button.Cell.locX + i].bColor = Color.Red;
                        cells.Add(board.cells[button.Cell.locY + i, button.Cell.locX + i]);
                    }
                    break;
                }
            }
            for (i = 1; button.Cell.locY - i > -1 && button.Cell.locX - i > -1; i++)
            {
                if (board.cells[button.Cell.locY - i, button.Cell.locX - i].figure == null)
                {
                    board.cells[button.Cell.locY - i, button.Cell.locX - i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.Cell.locY - i, button.Cell.locX - i]);
                }
                else if (board.cells[button.Cell.locY - i, button.Cell.locX - i].figure != null)
                {
                    if (board.cells[button.Cell.locY - i, button.Cell.locX - i].figure.color != button.Cell.figure.color)
                    {
                        board.cells[button.Cell.locY - i, button.Cell.locX - i].bColor = Color.Red;
                        cells.Add(board.cells[button.Cell.locY - i, button.Cell.locX - i]);
                    }
                    break;
                }
            }
            for (i = 1; button.Cell.locY + i < 8 && button.Cell.locX - i > -1; i++)
            {
                if (board.cells[button.Cell.locY + i, button.Cell.locX - i].figure == null)
                {
                    board.cells[button.Cell.locY + i, button.Cell.locX - i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.Cell.locY + i, button.Cell.locX - i]);
                }
                else if (board.cells[button.Cell.locY + i, button.Cell.locX - i].figure != null)
                {
                    if (board.cells[button.Cell.locY + i, button.Cell.locX - i].figure.color != button.Cell.figure.color)
                    {
                        board.cells[button.Cell.locY + i, button.Cell.locX - i].bColor = Color.Red;
                        cells.Add(board.cells[button.Cell.locY + i, button.Cell.locX - i]);
                    }
                    break;
                }
            }
            for (i = 1; button.Cell.locY - i > -1 && button.Cell.locX + i < 8; i++)
            {
                if (board.cells[button.Cell.locY - i, button.Cell.locX + i].figure == null)
                {
                    board.cells[button.Cell.locY - i, button.Cell.locX + i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.Cell.locY - i, button.Cell.locX + i]);
                }
                else if (board.cells[button.Cell.locY - i, button.Cell.locX + i].figure != null)
                {
                    if (board.cells[button.Cell.locY - i, button.Cell.locX + i].figure.color != button.Cell.figure.color)
                    {
                        board.cells[button.Cell.locY - i, button.Cell.locX + i].bColor = Color.Red;
                        cells.Add(board.cells[button.Cell.locY - i, button.Cell.locX + i]);
                    }
                    break;
                }
            }
            for (i = button.Cell.locX - 1; i > -1; i--)
            {
                if (board.cells[button.Cell.locY, i].figure == null)
                {
                    board.cells[button.Cell.locY, i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.Cell.locY, i]);
                }
                else if (board.cells[button.Cell.locY, i].figure != null)
                {
                    if (board.cells[button.Cell.locY, i].figure.color != button.Cell.figure.color)
                    {
                        board.cells[button.Cell.locY, i].bColor = Color.Red;
                        cells.Add(board.cells[button.Cell.locY, i]);
                    }
                    break;
                }
            }
            for (i = button.Cell.locX + 1; i < 8; i++)
            {
                if (board.cells[button.Cell.locY, i].figure == null)
                {
                    board.cells[button.Cell.locY, i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.Cell.locY, i]);
                }
                else if (board.cells[button.Cell.locY, i].figure != null)
                {
                    if (board.cells[button.Cell.locY, i].figure.color != button.Cell.figure.color)
                    {
                        board.cells[button.Cell.locY, i].bColor = Color.Red;
                        cells.Add(board.cells[button.Cell.locY, i]);
                    }
                    break;
                }
            }
            for (i = button.Cell.locY - 1; i > -1; i--)
            {
                if (board.cells[i, button.Cell.locX].figure == null)
                {
                    board.cells[i, button.Cell.locX].bColor = Color.Yellow;
                    cells.Add(board.cells[i, button.Cell.locX]);
                }
                else if (board.cells[i, button.Cell.locX].figure != null)
                {
                    if (board.cells[i, button.Cell.locX].figure.color != button.Cell.figure.color)
                    {
                        board.cells[i, button.Cell.locX].bColor = Color.Red;
                        cells.Add(board.cells[i, button.Cell.locX]);
                    }
                    break;
                }
            }
            for (i = button.Cell.locY + 1; i < 8; i++)
            {
                if (board.cells[i, button.Cell.locX].figure == null)
                {
                    board.cells[i, button.Cell.locX].bColor = Color.Yellow;
                    cells.Add(board.cells[i, button.Cell.locX]);
                }
                else if (board.cells[i, button.Cell.locX].figure != null)
                {
                    if (board.cells[i, button.Cell.locX].figure.color != button.Cell.figure.color)
                    {
                        board.cells[i, button.Cell.locX].bColor = Color.Red;
                        cells.Add(board.cells[i, button.Cell.locX]);
                    }
                    break;
                }
            }
            return cells;
        }
    }
}
