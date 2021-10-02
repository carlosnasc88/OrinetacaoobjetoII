using _06__ByteBank;
using System;

namespace _06___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {


            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Carlos";
            cliente.CPF = "127.105.106.07";
            cliente.Profissao = "Desenvolvedor C#";


            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);




            Console.ReadLine();



        }
    }
}
