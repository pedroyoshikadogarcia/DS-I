using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class ContaCorrente
    {
        public string nome;
        public string cpf;
        public double limiteCredito;
        public double saldo;
        public bool negativado;

       
        public void depositar()
        {
            Console.WriteLine("Olá " + nome + "\n");
            Console.WriteLine("Digite o valor que deseja depositar:\n");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            saldo += valorDeposito;
            Console.WriteLine("Depósito realizado com sucesso! Novo saldo: R$ " + saldo);
        }

        public void sacar()
        {
            Console.WriteLine("Digite o valor que deseja sacar:\n");
            double saque = Convert.ToDouble(Console.ReadLine());
            if (saque <= saldo)
            {
                saldo -= saque;
                Console.WriteLine("Saque realizado com sucesso! Novo saldo: R$ " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
                negativado = true;
                Console.WriteLine("Conta negativada.");
            }
        }

        public void verSaldo()
        {
            Console.WriteLine("O saldo atual da conta é: R$ " + saldo);
        }


        public static void Main(string[] args)
        {

            ContaCorrente cc1 = new ContaCorrente();

            Console.WriteLine("Digite seu nome:\n");
            cc1.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF:\n");
            cc1.cpf = Console.ReadLine();
            cc1.limiteCredito = 5000.00;
            cc1.saldo = 0;
            cc1.negativado = false;

            cc1.depositar();
            cc1.sacar();
            cc1.verSaldo();

        }
    }
}