﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Queen : Figure 
    {
        public Queen(string color) : base(color)
        {
            this.color = color;
        }
        public override List<Cell> CheckMove(Board board, Cstm_Button button)
        {

            return new List<Cell>();
        }
    }
}
