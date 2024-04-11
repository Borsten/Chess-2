using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Chess
{
    public class Pawn : Figure
    {
        public Pawn(string color) : base(color)
        {
            this.color = color;
        }

        public override List<Cell> CheckMove(Board board, Cstm_Button button)
        {
            List<Cell> cells = new List<Cell>();
            return cells;
        }
    }
}
