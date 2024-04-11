using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class Figure
    {
        public string color;

        public Figure(string color)
        {
            this.color = color;            
        }

        public abstract List<Cell> CheckMove(Board board, Cstm_Button button);
    }
}
