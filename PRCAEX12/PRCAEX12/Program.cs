using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX12
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri;
            tri = new Triangulo();
            Console.Write("Digite o valor primeiro valor: ");
            tri.setA(int.Parse(Console.ReadLine()));
            Console.Write("Digite o valor segundo lado: ");
            tri.setB(int.Parse(Console.ReadLine()));
            Console.Write("Digite o valor terceiro lado: ");
            tri.setC(int.Parse(Console.ReadLine()));
            tri.triangulo();
            if (tri.getTr() > tri.getC())
            {
                Console.WriteLine("é um triângulo");
            }
             if (tri.getTr() < tri.getC())
            {
                Console.WriteLine("Não é um triangulo");
               
            }
            
            if (tri.getA() == tri.getB() && tri.getB() == tri.getC())
            {
                Console.WriteLine("é um triangulo equilatero");
            }
             if (tri.getA() == tri.getB() && tri.getB() != tri.getC())
            {
                Console.WriteLine("é um triangulo isóceles");
            }
             if (tri.getA() != tri.getB() && tri.getB() != tri.getC())
            {
                Console.WriteLine("é um triangulo escaleno");
            }
           
        } 
    }    
}
