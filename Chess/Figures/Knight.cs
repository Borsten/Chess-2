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
        public override List<Cell> CheckMove(Board board, Cell button)
        {
            List<Cell> cells = new List<Cell>();
            if (button.locX > 1)
            {
                if (button.locY > 0)
                    cells.Add(CalculateMove(cells, board, button, 2, 1));

                if (button.locY < 7)
                    cells.Add(CalculateMove(cells, board, button, 2, -1));
            }
            if (button.locX < 6)
            {
                if (button.locY > 0)
                    cells.Add(CalculateMove(cells, board, button, -2, 1));

                if (button.locY < 7)
                    cells.Add(CalculateMove(cells, board, button, -2, -1));
            }
            if (button.locY > 1)
            {
                if (button.locX > 0)
                    cells.Add(CalculateMove(cells, board, button, 1, 2));
                if (button.locX < 7)
                    cells.Add(CalculateMove(cells, board, button, -1, 2));
            }
            if (button.locY < 6)
            {
                if (button.locX > 0)
                    cells.Add(CalculateMove(cells, board, button, 1, -2));
                if (button.locX < 7)
                    cells.Add(CalculateMove(cells, board, button, -1, -2));
            }
            foreach (Cell cell in cells)
            {
                board.cells[cell.locY, cell.locX] = cell;
            }
            return cells;
        }
        private Cell CalculateMove(List<Cell> cells, Board board, Cell button, int xOff, int yOff)
        {
            if (board.cells[button.locY - yOff, button.locX - xOff].figure == null)
            {
                Cell cell = new Cell(button.locX - xOff, button.locY - yOff, null, Color.Yellow);
                return cell;
            }
            else if (board.cells[button.locY - yOff, button.locX - xOff].figure.color != button.figure.color)
            {
                Cell cell = new Cell(button.locX - xOff, button.locY - yOff, null, Color.Red);
                cell.figure = board.cells[button.locY - yOff, button.locX - xOff].figure;
                return cell;
            }
            return board.cells[button.locY - yOff, button.locX - xOff];
        }
    }
}