using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX13
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();
            Console.Write("Digite a hipotenusa: ");
            tri.setA(int.Parse(Console.ReadLine()));
            Console.Write("Digite o cateto: ");
            tri.setB(int.Parse(Console.ReadLine()));
            Console.Write("Digite o cateto: ");
            tri.setC(int.Parse(Console.ReadLine()));
            tri.hipotenusa();
            if (tri.getA() == tri.getS())
            {
                Console.WriteLine("é um triangulo retangulo");
            }
            if (tri.getA() != tri.getS())
            {
                Console.WriteLine(" não é um triangulo retangulo");
            }



        }
    }
}
