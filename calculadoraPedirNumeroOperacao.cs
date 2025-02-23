using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraPedirNumeroOperacao
{
    public class calculadoraPedirNumeroOperacao
    {
        public double n1;
        public double n2;
        public string operacao;

        public void Calcular()
        {
            switch (operacao)
            {
                case "soma":
                    Console.WriteLine("Resultado da soma = " + (n1 + n2));
                    break;

                case "subtracao":
                    Console.WriteLine("Resultado da subtração = " + (n1 - n2));
                    break;
                case "multiplicacao":
                    Console.WriteLine("Resultado da multiplicação = " + (n1 * n2));
                    break;
                case "divisao":
                    if (n2 != 0 && n1 != 0)
                        Console.WriteLine("Resultado da divisão = " + (n1 / n2));
                    else
                        Console.WriteLine("Divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            calculadoraPedirNumeroOperacao c1 = new calculadoraPedirNumeroOperacao();

            Console.WriteLine("Digite o primeiro número: ");
            c1.n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            c1.n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a operação matemática: (soma, subtracao, multiplicacao e divisao)\n ");
            c1.operacao = Console.ReadLine().ToLower();

            Console.WriteLine("Número 1: " + c1.n1);
            Console.WriteLine("Número 2: " + c1.n2);
            Console.WriteLine("Operação escolhida: " + c1.operacao);

            c1.Calcular();

        }
    }
}
