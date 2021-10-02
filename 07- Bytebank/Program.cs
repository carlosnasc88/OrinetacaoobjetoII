using _07__ByteBank;
using System;

namespace _07__Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {


            ContaCorrente conta = new ContaCorrente( 867,86711247);
            conta.Numero = 867;
            conta.Agencia = 86711247;






            Console.WriteLine(conta.Agencia);




             
            Console.ReadLine();
        }
    }
}
