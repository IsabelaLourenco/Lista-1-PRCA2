using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCA2EX3
{
    class Quadrado
    {
        private int d;
        private int area;

        public void setDiagonal(int n)
        {
            d = n;
        }
        public int getDiagonal()
        {
            return d;
        }
        public int getArea()
        {
            return area;
        }

        public void resultado ()
        {
            area = (int)((Math.Pow(d, 2)) / 2);
        }
    }
}
