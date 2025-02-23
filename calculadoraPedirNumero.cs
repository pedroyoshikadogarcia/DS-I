using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraPedido
{
    public class calculadoraPedirNumero
    {
        public double n1;
        public double n2;
       

        public void Somar()
        {
            Console.WriteLine("A soma é = " + (n1 + n2));
        }

        public static void Main(string[] args)
        {
            calculadoraPedirNumero c1 = new calculadoraPedirNumero();

            Console.WriteLine("Digite um número ");
            c1.n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro número ");
            c1.n2 = Convert.ToDouble(Console.ReadLine());

          
            c1.Somar();
            

        }
    }
}
