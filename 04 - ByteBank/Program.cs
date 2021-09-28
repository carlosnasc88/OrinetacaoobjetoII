using System;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrete ContadaErica = new ContaCorrete();

            ContadaErica.titular = "Erica Andrade";

            Console.WriteLine(ContadaErica.saldo);

           bool resultadooSaque =  ContadaErica.Sacar(500);

            Console.WriteLine(ContadaErica.saldo);


            ContadaErica.Depositar(500);
            Console.WriteLine(ContadaErica.saldo);





            ContaCorrete contadoCarlos = new ContaCorrete();
            contadoCarlos.titular = "Carlos Nascimento";

            Console.WriteLine("Saldo conta do Carlos: " + contadoCarlos.saldo);
            Console.WriteLine("Saldo conta da Erica: " + ContadaErica.saldo);


            bool resultadoTransferencia = ContadaErica.Transferir(50, ContadaErica);

            Console.WriteLine("Saldo conta do Carlos: " + contadoCarlos.saldo);
            Console.WriteLine("Saldo conta da Erica: " + ContadaErica.saldo);

            Console.WriteLine("Resultado da Transferencia:" + resultadoTransferencia);






            Console.ReadLine();


            /*Nessa aula falamos sobre o comportamento que são os métodos.

            Vimos:   como definir métodos com parâmetros e retorno;
            como retornar algo usando a palavra chave return antes da expressão do resultado;
            o uso do return para retornar antecipadamente a execução de um método;
            como usar a referência this para acessar um atributo;
            que podemos passar uma referência como parâmetro do método;
            métodos são chamadas a partir da referência usando o operador
                */

        }
    }
}
