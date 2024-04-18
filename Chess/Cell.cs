using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Cell
    {
        public Figure figure;
        public Color bColor;
        public int locX;
        public int locY;

        public Cell(int locX, int locY, Figure figure, Color bColor)
        {
            this.locX = locX;
            this.locY = locY;
            this.figure = figure;
            this.bColor = bColor;
        }

        public Cell DeepCopy(Cell cell)
        {
            Cell c = new Cell(cell.locX, cell.locY, cell.figure, cell.bColor);
            return c;
        }
        public void test()
        {
            this.bColor = Color.White;
        }
    }
}