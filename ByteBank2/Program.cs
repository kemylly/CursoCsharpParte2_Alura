using System;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula 4
            Cliente yona = new Cliente();

            yona.nome = "Yona";
            yona.profissao = "Desenvolvedora C#";
            yona.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            //voce pode inicializar diretio na classe

            conta.titular = yona;
            conta.saldo = 600;
            conta.agencia = 465;
            conta.numero = 645123;

            Console.WriteLine(yona.nome);
            Console.WriteLine(conta.titular.nome);

            conta.titular.nome = "Yona princesa";

            Console.WriteLine(conta.titular.nome);

            //outro jeito de fazer
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();
            contaDaCamila.titular.nome = "Camila";
            contaDaCamila.titular.cpf = "434.562.878-20";
            contaDaCamila.titular.profissao = "Desenvolvedora C#";
            Console.WriteLine(contaDaCamila.titular.nome);
            Console.WriteLine(contaDaCamila.titular.cpf);
            Console.WriteLine(contaDaCamila.titular.profissao);

            Console.ReadLine();
        }
    }
}
