using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class Board
    {
        public List<Cell> cells;

        public Board CreateNewBoard(List<Cell> cells)
        {
            Board board = new Board();
            Color color = Color.White;
            int count = 0;
            int comp = 8;
            Figure figure = new Rook("Black");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ( count % 2 == 0 )
                        color = Color.White;
                    else
                        color = Color.Black;
                    count++;
                    if (count == comp)
                    {
                        if (comp == 8)
                        {
                            count = 1;
                            comp = 9;
                        }
                        else
                        {
                            count = 0;
                            comp = 8;
                        }
                    }
                    switch (i)
                    {
                        case 0:
                            switch (j)
                            {
                                case 0:
                                    break;
                                case 1:
                                    figure = new Knight("Black");
                                    break;
                                case 2:
                                    figure = new Bishop("Black");
                                    break;
                                case 3:
                                    figure = new Queen("Black");
                                    break;
                                case 4:
                                    figure = new King("Black");
                                    break;
                                case 5:
                                    figure = new Bishop("Black");
                                    break;
                                case 6:
                                    figure = new Knight("Black");
                                    break;
                                case 7:
                                    figure = new Rook("Black");
                                    break;                                        
                            }
                            break;
                        case 1:
                            figure = new Pawn("Black");
                            break;
                        case 6:
                            figure = new Pawn("White");
                            break;
                        case 7:
                            switch (j)
                            {
                                case 0:
                                    break;
                                case 1:
                                    figure = new Knight("White");
                                    break;
                                case 2:
                                    figure = new Bishop("White");
                                    break;
                                case 3:
                                    figure = new Queen("White");
                                    break;
                                case 4:
                                    figure = new King("White");
                                    break;
                                case 5:
                                    figure = new Bishop("White");
                                    break;
                                case 6:
                                    figure = new Knight("White");
                                    break;
                                case 7:
                                    figure = new Rook("White");
                                    break;
                            }
                            break;
                        default:
                            figure = null;
                            break;                       
                    }
                    cells.Add(new Cell(i, j, figure, color));
                }
            }
            board.cells = cells;
            int x = 0;
            return board;
        }

        public void DrawBoard(Board board)
        { }
    }
}
