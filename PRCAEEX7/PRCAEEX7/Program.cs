using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEEX7
{
    class Program
    {
        static void Main(string[] args)
        {
            Moeda moeda;
            moeda = new Moeda();
            Console.Write("Digite a cotação do dolar: ");
            moeda.setCotacao(Double.Parse(Console.ReadLine()));
            Console.Write("Digite a quantidade do dolar: ");
            moeda.setDolar(Double.Parse(Console.ReadLine()));
            moeda.resultado();
            Console.WriteLine("{0} dolares equivalem a {1} reais",
                 moeda.getDolar(), moeda.getReal());
        }
    }
}
