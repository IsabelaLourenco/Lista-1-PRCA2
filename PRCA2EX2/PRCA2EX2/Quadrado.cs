using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCA2EX2
{
    class Quadrado
    {
        private int aresta;
        private int area;
        
        public void setAresta( int n)
        {
            aresta = n;
        }
        public int getAresta()
        {
            return aresta;
        }
        public int getArea()
        {
            return area;
        }
        public void resultado()
        {
            area = (int)Math.Pow(aresta,2);
        }
    }
}
