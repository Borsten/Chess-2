using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Pawn : Figure
    {
        public Pawn(string color) : base(color)
        {
            this.color = color;
        }
    }
}
