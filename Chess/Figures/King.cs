using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : Figure
    {
        public King(string color) : base(color)
        {
            this.color = color;
        }

        public override List<Cell> CheckMove(Board board, Cell button)
        {
            List<Cell> cells = new List<Cell>();
            if (button.locX > 0) 
            {
                cells.Add(CalculateMove(board, button, -1, 0));
                if (button.locY > 0)
                {
                    cells.Add(CalculateMove(board, button, -1, -1));
                }
            }
            if (button.locY > 0) 
            {
                cells.Add(CalculateMove(board, button, 0, -1));
                if (button.locX < 8)
                {
                    cells.Add(CalculateMove(board, button, 1, -1));
                }
            }
            if (button.locX < 7)
            {
                cells.Add(CalculateMove(board, button, 1, 0));
                if (button.locY < 7)
                {
                    cells.Add(CalculateMove(board, button, 1, 1));
                }
            }
            if (button.locY < 7)
            {
                cells.Add(CalculateMove(board, button, 0, 1));
                if (button.locX < 8)
                {
                    cells.Add(CalculateMove(board, button, -1, 1));
                }
            }
            cells = CheckCell(board, button, cells);
            return cells;
        }
        private Cell CalculateMove(Board board, Cell button, int xOff, int yOff)
        {
            if (board.cells[button.locY + yOff, button.locX + xOff].figure == null)
            {
                Cell cell = new Cell(button.locX + xOff, button.locY + yOff, null, Color.Yellow);
                return cell;
            }
            else if (board.cells[button.locY + yOff, button.locX + xOff].figure.color != button.figure.color)
            {
                Cell cell = new Cell(button.locX + xOff, button.locY + yOff, null, Color.Red);
                return cell;
            }
            return board.cells[button.locY + yOff, button.locX + xOff];
        }
        private List<Cell> CheckCell(Board board, Cell button, List<Cell> cells)
        {
            Cell c = new Cell(0, 0, null, Color.White);
            List<Cell> check = new List<Cell>();
            List<Cell> removeCell = new List<Cell>();
            foreach (Cell cell in cells)
            {
                c = cell.DeepCopy(cell);
                c.figure = new Pawn(button.figure.color);
                check = c.figure.CheckMove(board, c);
                foreach (Cell checkCell in check)
                {
                    if (checkCell.bColor == Color.Red && checkCell.figure.GetType() == typeof(Pawn))
                    {
                        removeCell.Add(cell); 
                        break;
                    }
                }
                c.figure = new Knight(button.figure.color);
                check = c.figure.CheckMove(board, c);
                foreach (Cell checkCell in check)
                {
                    if (checkCell.bColor == Color.Red && checkCell.figure.GetType() == typeof(Knight))
                    {
                        removeCell.Add(cell);
                        break;
                    }
                }
                c.figure = new Bishop(button.figure.color);
                check = c.figure.CheckMove(board, c);
                foreach (Cell checkCell in check)
                {
                    if (checkCell.bColor == Color.Red && (checkCell.figure.GetType() == typeof(Bishop) || checkCell.figure.GetType() == typeof(Queen)))
                    {
                        removeCell.Add(cell);
                        break;
                    }
                }
                c.figure = new Rook(button.figure.color);
                check = c.figure.CheckMove(board, c);
                foreach (Cell checkCell in check)
                {
                    if (checkCell.bColor == Color.Red && (checkCell.figure.GetType() == typeof(Rook) || checkCell.figure.GetType() == typeof(Queen)))
                    {
                        removeCell.Add(cell);
                        break;
                    }
                }
            }
            foreach (Cell remove in removeCell) 
            { 
                cells.Remove(remove);
            }
            return cells;
        }
    }
}
