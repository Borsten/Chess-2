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
        private List<Cell> CheckCell(Board board, Cstm_Button button, List<Cell> cells)
        {
            bool threat = false;
            Cell c = new Cell(0, 0, null, Color.White);
            foreach (Cell cell in cells)
            {
                List<Cell> checkCells = new List<Cell> ();
                //CheckPawn
                c = cell;
                c.figure = new Pawn(button.Cell.figure.color);
                checkCells = c.figure.CheckMove(board, c);

                foreach (Cell checkCell in checkCells)
                {
                    if (checkCell.bColor == Color.Red)
                    {
                        
                    }
                }

                //CheckKnight
                c.figure = new Knight(button.Cell.figure.color);
                c.figure.CheckMove(board, c);

                //CheckQueen
                c.figure = new Queen(button.Cell.figure.color);
                c.figure.CheckMove(board, c);

            }
            return threat;
        }
    }
}
