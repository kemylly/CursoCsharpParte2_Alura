using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.titular = "yona";
            contaCorrente.agencia = 465;
            contaCorrente.numero = 465123;
            contaCorrente.saldo = 100;

            Console.WriteLine(contaCorrente.titular);
            Console.WriteLine("Agencia: " + contaCorrente.agencia);
            Console.WriteLine("Numero: " + contaCorrente.numero);
            Console.WriteLine("Saldo: " + contaCorrente.saldo);

            contaCorrente.saldo += 50;

            Console.WriteLine("Saldo: " + contaCorrente.saldo);

            //aula 2

            ContaCorrente contaCorrente1 = new ContaCorrente();
            contaCorrente1.titular = "Hak";
            contaCorrente1.agencia = 465;
            contaCorrente1.numero = 465111;
            contaCorrente1.saldo = 10;

            Console.WriteLine("É igual? " + ( contaCorrente == contaCorrente1)); //False => são endereços/referencias diferentes

            int idade = 465;
            Console.WriteLine(contaCorrente.agencia == idade); //são iguais => true

            contaCorrente = contaCorrente1; //tornando a mesma coisa => apontando para o mesmo lugar na amemoria
            Console.WriteLine("É igual? " + ( contaCorrente == contaCorrente1));  //são iguais => true

            contaCorrente.saldo = 300;
            Console.WriteLine(contaCorrente.saldo);
            Console.WriteLine(contaCorrente1.saldo);

            if(contaCorrente.saldo >= 100)
            {
                contaCorrente.saldo -= 100;
            }

            //aula 3
            ContaCorrente contaEpson = new ContaCorrente();

            contaEpson.titular = "Epson";
            contaEpson.saldo = 100;
            Console.WriteLine(contaEpson.saldo);

            contaEpson.Sacar(50); //sacando 50 reias da conta
            Console.WriteLine(contaEpson.saldo);

            bool resultado = contaEpson.Sacar(500); //sacando 50 reias da conta
            Console.WriteLine(resultado);

            Console.WriteLine(contaEpson.saldo);
            contaEpson.Depositar(500); //depositando 500 na conta 
            Console.WriteLine(contaEpson.saldo);

            //fazer tranferencia
            Console.WriteLine("Saldo antes da yona : "+ contaCorrente.saldo);
            Console.WriteLine("Saldo antes da epson : "+ contaEpson.saldo);
            contaEpson.Transferir(100, contaCorrente); //true
            Console.WriteLine("Saldo depois da yona : "+ contaCorrente.saldo);
            Console.WriteLine("Saldo depois da epson : "+ contaEpson.saldo);

            Console.WriteLine("Saldo antes da yona : "+ contaCorrente.saldo);
            Console.WriteLine("Saldo antes da epson : "+ contaEpson.saldo);
            bool resultado1 = contaEpson.Transferir(1000, contaCorrente);  //false
            Console.WriteLine("Resultado : "+ resultado1);
            Console.WriteLine("Saldo depois da yona : "+ contaCorrente.saldo);
            Console.WriteLine("Saldo depois da epson : "+ contaEpson.saldo);

            Console.ReadLine();
        }
    }
}
