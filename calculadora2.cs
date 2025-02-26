using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    public class Calculadora2
    {
        public double n1;
        public double n2;
        public void somar()
        {
            Console.WriteLine("soma = " + (n1 + n2));
        }

        public void subtracao()
        {
            Console.WriteLine("subtração = " + (n1 - n2));
        }

        public void multiplicacao()
        {
            Console.WriteLine("multiplicacao = " + (n1 * n2));
        }
        public void divisao()
        {
            Console.WriteLine("divisao = " + (n1 / n2));
        }
        public static void Main(string[] args)
        {
            Calculadora2 c1 = new Calculadora2();

            c1.n1 = 2;
            c1.n2 = 3;
            Console.WriteLine(c1.n1);
            Console.WriteLine(c1.n2);

            c1.somar();
            c1.subtracao();
            c1.multiplicacao();
            c1.divisao();

            Console.WriteLine("\n");

            Calculadora c2 = new Calculadora();

            c2.n1 = 98;
            c2.n2 = 105;
            Console.WriteLine(c2.n1);
            Console.WriteLine(c2.n2);

            c2.somar();
            c2.subtracao();
            c2.multiplicacao();
            c2.divisao();

            Console.WriteLine("\n");

        }
    }
}
