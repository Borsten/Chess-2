using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public List<Button> Buttons = new List<Button>();
        Board board = new Board();

        public Form1()
        {
            InitializeComponent();
            board = board.CreateNewBoard(new List<Cell>());
            DrawBoard(board);
        }
        public void DrawBoard(Board board)
        {
            foreach (Cell c in board.cells)
            {
                CreateNewButton(c);
            }
        }

        public void CreateNewButton(Cell c)
        {
            Cstm_Button button = new Cstm_Button();
            button.Cell = c;
            button.Location = new Point(20 + 50 * c.locY, 20 + 50 * c.locX);
            button.Size = new Size(50, 50);
            button.BackColor = c.bColor;
            button.Click += btn_Click;
            if (c.figure != null)
            {
                if (button.BackColor == Color.Black)
                    button.ForeColor = Color.White;
                
                button.Text = c.figure.color + " " + c.figure.GetType().Name;
            }
            this.Controls.Add(button);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Cstm_Button b = (Cstm_Button)sender;
            foreach (Cell c in board.cells)
            {

            }
        }
    }
}
