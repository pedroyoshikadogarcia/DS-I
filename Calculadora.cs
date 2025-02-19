using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public double n1;
        public double n2;
        public void somar()
        {
            Console.WriteLine("soma = "+ (n1+n2));
        }
       public static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();

            c1.n1 = 2;
            c1.n2 = 3;
            Console.WriteLine(c1.n1);
            Console.WriteLine(c1.n2);
            c1.somar();

        }
    }
}
