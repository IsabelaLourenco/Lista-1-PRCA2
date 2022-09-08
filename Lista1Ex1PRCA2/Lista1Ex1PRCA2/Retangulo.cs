using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1PRCA2
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
        public int getB()
        {
           return b;
        }
        public int getH()
        {
            return h;
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
