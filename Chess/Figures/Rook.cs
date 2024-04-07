using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Rook : Figure
    {
        public Rook(string color) : base(color)
        {
            this.color = color;
        }
    }
}
