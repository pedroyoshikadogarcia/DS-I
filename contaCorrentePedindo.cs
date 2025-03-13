using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ContaCorrente
{
    public class ContaCorrente
    {
        public string nome;
        public string cpf;
        public double limiteCredito;
        public double saldo;
        public bool negativado;


        public double depositar(double valor)
        {
            Console.WriteLine("Olá " + nome + "\n");
            saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso! Novo saldo: R$ " + saldo);
            return saldo;
        }

        public double sacar(double saque)
        {
            saldo -= saque;
            return saldo;
        }

        public void verSaldo()
        {
            Console.WriteLine("O saldo atual da conta é: R$ " + saldo);
        }


        public static void Main(string[] args)
        {

            ContaCorrente cc1 = new ContaCorrente();

            Console.WriteLine("Digite seu nome: ");
            cc1.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF:\n");
            cc1.cpf = Console.ReadLine();
            cc1.limiteCredito = 5000.00;
            cc1.saldo = 0;
            cc1.negativado = false;
            Console.WriteLine("Digite o valor do depósito ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());

            cc1.depositar(valor);
            cc1.sacar(saque);
            cc1.verSaldo();

        }
    }
}