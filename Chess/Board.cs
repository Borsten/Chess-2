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

        private ChessForm form;

        public Board GetBoard()
        {
            return this;
        }

        public Board CreateNewBoard(Cell[,] cells)
        {

            Figure figure = new Rook("Black");
            for (int locY = 0; locY < 8; locY++)
            {
                for (int locX = 0; locX < 8; locX++)
                {
                    if ((locX + locY) % 2 == 0)
                        color = Color.White;
                    else
                        color = Color.Black;
                    switch (locY)
                    {
                        case 0:
                            switch (locX)
                            {
                                case 0:
                                    figure = new Rook("Black");
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
                        case 4:
                            if (locX == 4)
                                figure = new King("Black");
                            else
                                figure = null;
                            break;
                        //case 1:
                        //    figure = new Pawn("Black");
                        //    break;
                        case 5:
                            figure = new Pawn("Black");
                            break;
                        case 7:
                            switch (locX)
                            {
                                case 0:
                                    figure = new Rook("White");
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
            this.cells = cells;
            return this;
        }

        public void UpdateBoard(List<Cell> cells)
        {
            foreach (Cell c in cells)
            {
                if (c.bColor == Color.Red || c.bColor == Color.Yellow)
                {
                    form.Buttons[c.locY, c.locX].Cell = c;
                    form.Buttons[c.locY, c.locX].BackColor = c.bColor;                   
                    form.Buttons[c.locY, c.locX].Enabled = true;
                    if (c.figure != null)
                    {
                        form.Buttons[c.locY, c.locX].Text = c.figure.color + " " + c.figure.GetType().Name;
                        if (c.bColor == Color.Black)
                            form.Buttons[c.locY, c.locX].ForeColor = Color.White;
                    }
                }
            }
            int x = 0;
        }

        public void DrawBoard(Board board, ChessForm form)
        {
            this.form = form;
            for (int locY = 0; locY < 8; locY++)
            {
                for (int locX = 0; locX < 8; locX++)
                {
                    CreateNewButton(locX, locY, board);
                }
            }
        }

        public void CreateNewButton(int locX, int locY, Board b)
        {
            Cstm_Button button = new Cstm_Button();
            button.Cell = b.cells[locY, locX];
            button.Location = new Point(20 + 50 * locX, 20 + 50 * locY);
            button.Size = new Size(50, 50);
            button.BackColor = b.cells[locY, locX].bColor;
            button.Enabled = false;
            button.Click += btn_Click;
            if (b.cells[locY, locX].figure != null)
            {
                if (button.BackColor == Color.Black)
                    button.ForeColor = Color.White;
                button.Enabled = true;
                button.Text = b.cells[locY, locX].figure.color + " " + b.cells[locY, locX].figure.GetType().Name;
            }
            form.Buttons[locY, locX] = button;
            form.Controls.Add(button);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<Cell> cells = new List<Cell>();
            Cstm_Button b = (Cstm_Button)sender;
            int locX = b.Cell.locX;
            int locY = b.Cell.locY;
            foreach (Cell cell in form.board.cells)
            {
                if (cell.figure == null)
                    form.Buttons[cell.locY, cell.locX].Enabled = false;
                if ((cell.locX + cell.locY) % 2 == 0)
                {
                    form.Buttons[cell.locY, cell.locX].BackColor = Color.White;
                    this.cells[locY, locX].bColor = Color.White;
                }
                else
                {
                    form.Buttons[cell.locY, cell.locX].BackColor = Color.Black;
                    form.Buttons[cell.locY, cell.locX].ForeColor = Color.White;
                    this.cells[locY, locX].bColor = Color.Black;
                }
            }
            if (b.Cell.figure != null)
                cells = b.Cell.figure.CheckMove(this, b.Cell);
            UpdateBoard(cells);
        }
    }
}