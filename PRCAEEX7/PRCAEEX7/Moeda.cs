using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEEX7
{
    class Moeda
    {
        private double dolar;
        private double cotacao;
        private double real;

        public void setDolar(double n)
        {
            dolar = n;
        }
        public double getDolar()
        {
            return dolar;
        }
        public void setCotacao(double n)
        {
            cotacao = n;
        }
        public double getCotacaor()
        {
            return cotacao;
        }
        public double getReal()
        {
            return real;
        }

        public void resultado()
        {
            real = cotacao * dolar;
        }
    }
}
