using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX12
{
    class Triangulo
    {
        private int a;
        private int b;
        private int c;
        private int tr;

        public void setA(int n)
        {
            a = n;
        }
        public void setB(int n)
        {
            b = n;
        }
        public void setC(int n)
        {
            c = n;
        }
        public int getA()
        {
            return a;
        }
        public int getB()
        {
            return b;
        }
        public int getC()
        {
            return c;
        }
        public int getTr()
        {
            return tr;
        }
        public void triangulo()
        {
           tr = a + b ;
        }

    }
}
