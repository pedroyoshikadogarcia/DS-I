using System;

namespace contaCorrente
{
    public class ContaCorrente
    {
        public string nome;
        public string cpf;
        public double limiteCredito;
        public double saldo;
        public bool negativado;

        public void depositar(double valor = 1000)
        {
            saldo += valor;
            Console.WriteLine("Depósito de: R$ " + valor + " realizado com sucesso.");
        }

        public void sacar(double valor = 500)
        {
            saldo -= valor;
            Console.WriteLine("Saque de: R$ " + valor + " realizado com sucesso.");
        }

        public void verSaldo()
        {
            Console.WriteLine("Seu saldo atual é de: R$ " + saldo);
        }

        static void Main(string[] args)
        {
            ContaCorrente cc1 = new ContaCorrente();

            cc1.nome = "Pedro";
            cc1.cpf = "000.000.000.00";
            cc1.limiteCredito = 5000.00;
            cc1.saldo = 0;
            cc1.negativado = false;

            Console.WriteLine("Cliente: " + cc1.nome);
            Console.WriteLine("CPF: " + cc1.cpf);
            Console.WriteLine("Limite de Crédito: R$ " + cc1.limiteCredito);
            Console.WriteLine("Seu saldo inicial é de: R$ " + cc1.saldo);

            cc1.depositar();
            cc1.sacar();
            cc1.verSaldo();
        }
    }
}
