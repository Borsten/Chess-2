using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public delegate void ClickEventHandler(object sender, ClickEventArgs e);
    public class ClickEventArgs : EventArgs 
    {
        public Board Board { get; set; }

        public ClickEventArgs(Board board)
        {
            Board = board;
        }
    }
}
