using System;
using ByteBank3;

namespace ByteBank3
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula 5
            ContaCorrente conta = new ContaCorrente(465, 465123);
            Cliente cliente = new Cliente();

            cliente.Nome = "kemylly";
            cliente.CPF = "123456789";
            cliente.Profissao = "programadora";

            conta.Saldo = -10;
            conta.Titular = cliente;

             Console.WriteLine("Nome da conta: " + conta.Titular.Nome);

            Console.WriteLine("Saldo da conta: " + conta.Saldo);

            //aula 6
            conta.Agencia = 465;
            Console.WriteLine(conta.Agencia);
            conta.Agencia = 0;
            Console.WriteLine(conta.Agencia);

            Console.WriteLine(ContaCorrente.TotalDeContas);

            Console.ReadLine();
        }
    }
}
