using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class Knight : Figure
    {
        public Knight(string color) : base(color)
        {
            this.color = color;
        }
        public override List<Cell> CheckMove(Board board, Cstm_Button button)
        {
            List<Cell> cells = new List<Cell>();
            if (button.Cell.locX > 1)
            {
                if (button.Cell.locY > 0)
                    cells.Add(CalculateMove(cells, board, button, 2, 1));

                if (button.Cell.locY < 7)
                    cells.Add(CalculateMove(cells, board, button, 2, -1));
            }
            if (button.Cell.locX < 6)
            {
                if (button.Cell.locY > 0)
                    cells.Add(CalculateMove(cells, board, button, -2, 1));

                if (button.Cell.locY < 7)
                    cells.Add(CalculateMove(cells, board, button, -2, -1));
            }
            if (button.Cell.locY > 1)
            {
                if (button.Cell.locX > 0)
                    cells.Add(CalculateMove(cells, board, button, 1, 2));
                if (button.Cell.locX < 7)
                    cells.Add(CalculateMove(cells, board, button, -1, 2));
            }
            if (button.Cell.locY < 6)
            {
                if (button.Cell.locX > 0)
                    cells.Add(CalculateMove(cells, board, button, 1, -2));
                if (button.Cell.locX < 7)
                    cells.Add(CalculateMove(cells, board, button, -1, -2));
            }
            foreach (Cell cell in cells)
            {      
                board.cells[cell.locY, cell.locX] = cell;
            }
            return cells;
        }
        private Cell CalculateMove(List <Cell> cells, Board board, Cstm_Button button, int xOff, int yOff)
        {
            if (board.cells[button.Cell.locY - yOff, button.Cell.locX - xOff].figure == null)
            {
                Cell cell = new Cell(button.Cell.locX - xOff, button.Cell.locY - yOff, null, Color.Yellow);
                return cell;
            }
            else if (board.cells[button.Cell.locY - yOff, button.Cell.locX - xOff].figure.color != button.Cell.figure.color)
            {
                Cell cell = new Cell(button.Cell.locX - xOff, button.Cell.locY - yOff, null, Color.Red);
                return cell;
            }
            return board.cells[button.Cell.locY - yOff, button.Cell.locX - xOff];
        }
    }
}
