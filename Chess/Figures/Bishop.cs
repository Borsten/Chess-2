using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Bishop : Figure
    {
        public Bishop(string color) : base(color)
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
            return cells;
        }
    }
}
