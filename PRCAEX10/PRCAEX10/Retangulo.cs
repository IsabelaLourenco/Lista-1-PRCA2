using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX10
{
    class Retangulo
    {
        private int b;
        private int h;
        private int a;
        public void setB(int n)
        {
            b = n;
        }
        public void setH(int n)
        {
            h = n;
        }
     
        public int getA()
        {
            return a;
        }
        public void area()
        {
            a = b * h;
        }
    }
}
