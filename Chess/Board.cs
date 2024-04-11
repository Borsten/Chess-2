using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Chess
{
    
    public class Board
    {
        public Cell[,] cells = new Cell[8, 8];
        private Color color = Color.White;
        private Color temp1 = Color.White;
        private Color temp2 = Color.Black;
        private Color swap;
        int count = 0;

        public Board CreateNewBoard(Cell[,] cells)
        {
            Board board = new Board();

            Figure figure = new Rook("Black");
            for (int locY = 0; locY < 8; locY++)
            {
                for (int locX = 0; locX < 8; locX++)
                {
                    if ( count % 2 == 0 )
                        color = temp1;
                    else
                        color = temp2;
                    count++;
                    if (count % 8 == 0)
                    {
                        swap = temp2;
                        temp2 = temp1;
                        temp1 = swap;
                    }
                    switch (locY)
                    {
                        case 0:
                            switch (locX)
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
                            switch (locX)
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
                    Cell c = new Cell(locX, locY, figure, color);   
                    cells[locY, locX] = c;
                }
            }
            board.cells = cells;
            return board;
        }
        public Board UpdateBoard(Board board, List<Cell> cells)
        { 
            return board; 
        }
        public void DrawBoard(Board board, Form form)
        {
            for (int locY = 0; locY < 8; locY++)
            {
                for (int locX = 0; locX < 8; locX++)
                {
                    CreateNewButton(locX, locY, board, form);
                }
            }
        }


        public void CreateNewButton(int locX, int locY, Board b, Form form)
        {
            Cstm_Button button = new Cstm_Button();
            button.Cell = b.cells[locY, locX];
            button.Location = new Point(20 + 50 * locX, 20 + 50 * locY);
            button.Size = new Size(50, 50);
            button.BackColor = b.cells[locY, locX].bColor;
            button.Click += btn_Click(b);
            button.Enabled = false;
            if (b.cells[locY, locX].figure != null)
            {
                if (button.BackColor == Color.Black)
                    button.ForeColor = Color.White;
                button.Enabled = true;
                button.Text = b.cells[locY, locX].figure.color + " " + b.cells[locY, locX].figure.GetType().Name;
            }
            form.Controls.Add(button);
        }



        private void btn_Click(object sender, ClickEventArgs e)
        {

        }
    }


}
