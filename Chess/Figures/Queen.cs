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
        public override List<Cell> CheckMove(Board board, Cell button)
        {
            int i;
            List<Cell> cells = new List<Cell>();
            for (i = 1; button.locY + i < 8 && button.locX + i < 8; i++)
            {
                if (board.cells[button.locY + i, button.locX + i].figure == null)
                {
                    board.cells[button.locY + i, button.locX + i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.locY + i, button.locX + i]);
                }
                else if (board.cells[button.locY + i, button.locX + i].figure != null)
                {
                    if (board.cells[button.locY + i, button.locX + i].figure.color != button.figure.color)
                    {
                        board.cells[button.locY + i, button.locX + i].bColor = Color.Red;
                        cells.Add(board.cells[button.locY + i, button.locX + i]);
                    }
                    break;
                }
            }
            for (i = 1; button.locY - i > -1 && button.locX - i > -1; i++)
            {
                if (board.cells[button.locY - i, button.locX - i].figure == null)
                {
                    board.cells[button.locY - i, button.locX - i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.locY - i, button.locX - i]);
                }
                else if (board.cells[button.locY - i, button.locX - i].figure != null)
                {
                    if (board.cells[button.locY - i, button.locX - i].figure.color != button.figure.color)
                    {
                        board.cells[button.locY - i, button.locX - i].bColor = Color.Red;
                        cells.Add(board.cells[button.locY - i, button.locX - i]);
                    }
                    break;
                }
            }
            for (i = 1; button.locY + i < 8 && button.locX - i > -1; i++)
            {
                if (board.cells[button.locY + i, button.locX - i].figure == null)
                {
                    board.cells[button.locY + i, button.locX - i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.locY + i, button.locX - i]);
                }
                else if (board.cells[button.locY + i, button.locX - i].figure != null)
                {
                    if (board.cells[button.locY + i, button.locX - i].figure.color != button.figure.color)
                    {
                        board.cells[button.locY + i, button.locX - i].bColor = Color.Red;
                        cells.Add(board.cells[button.locY + i, button.locX - i]);
                    }
                    break;
                }
            }
            for (i = 1; button.locY - i > -1 && button.locX + i < 8; i++)
            {
                if (board.cells[button.locY - i, button.locX + i].figure == null)
                {
                    board.cells[button.locY - i, button.locX + i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.locY - i, button.locX + i]);
                }
                else if (board.cells[button.locY - i, button.locX + i].figure != null)
                {
                    if (board.cells[button.locY - i, button.locX + i].figure.color != button.figure.color)
                    {
                        board.cells[button.locY - i, button.locX + i].bColor = Color.Red;
                        cells.Add(board.cells[button.locY - i, button.locX + i]);
                    }
                    break;
                }
            }
            for (i = button.locX - 1; i > -1; i--)
            {
                if (board.cells[button.locY, i].figure == null)
                {
                    board.cells[button.locY, i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.locY, i]);
                }
                else if (board.cells[button.locY, i].figure != null)
                {
                    if (board.cells[button.locY, i].figure.color != button.figure.color)
                    {
                        board.cells[button.locY, i].bColor = Color.Red;
                        cells.Add(board.cells[button.locY, i]);
                    }
                    break;
                }
            }
            for (i = button.locX + 1; i < 8; i++)
            {
                if (board.cells[button.locY, i].figure == null)
                {
                    board.cells[button.locY, i].bColor = Color.Yellow;
                    cells.Add(board.cells[button.locY, i]);
                }
                else if (board.cells[button.locY, i].figure != null)
                {
                    if (board.cells[button.locY, i].figure.color != button.figure.color)
                    {
                        board.cells[button.locY, i].bColor = Color.Red;
                        cells.Add(board.cells[button.locY, i]);
                    }
                    break;
                }
            }
            for (i = button.locY - 1; i > -1; i--)
            {
                if (board.cells[i, button.locX].figure == null)
                {
                    board.cells[i, button.locX].bColor = Color.Yellow;
                    cells.Add(board.cells[i, button.locX]);
                }
                else if (board.cells[i, button.locX].figure != null)
                {
                    if (board.cells[i, button.locX].figure.color != button.figure.color)
                    {
                        board.cells[i, button.locX].bColor = Color.Red;
                        cells.Add(board.cells[i, button.locX]);
                    }
                    break;
                }
            }
            for (i = button.locY + 1; i < 8; i++)
            {
                if (board.cells[i, button.locX].figure == null)
                {
                    board.cells[i, button.locX].bColor = Color.Yellow;
                    cells.Add(board.cells[i, button.locX]);
                }
                else if (board.cells[i, button.locX].figure != null)
                {
                    if (board.cells[i, button.locX].figure.color != button.figure.color)
                    {
                        board.cells[i, button.locX].bColor = Color.Red;
                        cells.Add(board.cells[i, button.locX]);
                    }
                    break;
                }
            }
            return cells;
        }
    }
}