using System;

namespace _05__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cliente carlos = new Cliente();
            carlos.nome = "Carlos";
            carlos.profissao = "Dev c#";
            carlos.cpf = "127.109.377-43";*/


            ContaCorrete conta = new ContaCorrete();
            //conta.titular = carlos;
           // conta.titular = new Cliente();
            //conta.titular.nome = "Carlos Nascimento";
            //conta.titular.cpf = "127.109.300-00";
            //conta.titular.profissao = "Dev C#";
            
            
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563457;

            if(conta.titular == null)
            {

                Console.WriteLine("Ops!!! a conta referencia é NULL");

            }




            //Console.WriteLine(carlos.nome);
            Console.WriteLine(conta.titular.nome);
           //Console.WriteLine(conta.titular.cpf);
           //Console.WriteLine(conta.titular.profissao);


            Console.ReadLine();

        }
    }
}


                /*Aprendemos neste capítulo:

                Realizar o relacionamento entre classes através de composição.
                Vantagens de se isolar informações repetidas em outra classe.
                Como namespaces funcionam no C#.
                O que forma o nome completo de uma classe.
                Como as diretivas using são usadas.
                O valor null.*/