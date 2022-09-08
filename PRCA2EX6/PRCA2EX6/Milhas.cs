using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCA2EX6
{
    class Milhas
    {
        private double milhas;
        private double valor;
        private double km = 1.852;


        public void setValormilhas(double n)
        {
            milhas = n;
        }
        public double getValormilhas()
        {
            return milhas;
        }
        public double getValorkm()
        {
            return valor;
        }

        public void resultado()
        {
            valor = milhas * km;
        }
    }
}
