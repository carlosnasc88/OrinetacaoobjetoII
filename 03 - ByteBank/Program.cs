using System;

namespace _03___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {


            ContaCorrete contaDoCarlos = new ContaCorrete();
            contaDoCarlos.titular = "Carlos";
            contaDoCarlos.agencia = 863;
            contaDoCarlos.numero = 512262;


            ContaCorrete contaDaErica = new ContaCorrete();
            contaDoCarlos.titular = "Erica";
            contaDoCarlos.agencia = 863;
            contaDoCarlos.numero = 512262;

            Console.WriteLine("Igualdade de Tipo de refência" + (contaDoCarlos == contaDaErica));

            int idade = 33;
            int idadeMaiUmaVez = 33;

            Console.WriteLine("Igualdade de tipo de valore" + (idade == idadeMaiUmaVez));



            contaDoCarlos = contaDaErica;

            contaDoCarlos.saldo = 300;


            Console.WriteLine(contaDoCarlos.saldo);
            Console.WriteLine(contaDaErica.saldo);






              /* Vimos:Como acessar e alterar campos de um objeto
                  Valores padrões de campos de classes Tipos de referência e tipos de valor
                  Inicialização de campos Como funciona a atribuição de uma referência à uma variável.

                    */

            Console.ReadLine();


        }
    }
}
