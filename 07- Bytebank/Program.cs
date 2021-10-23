using _07__ByteBank;
using System;

namespace _07__Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {


            ContaCorrente conta = new ContaCorrente(867,86711247);

            conta.Numero = 867;
            conta.Agencia = 86711247;
            Console.WriteLine (ContaCorrente.TotaldeContasCriadas);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contadoCarlos = new ContaCorrente(867, 86711247);
            Console.WriteLine(ContaCorrente.TotaldeContasCriadas);






            Console.ReadLine();
        }
    }
}

        /*Aprendemos nesta aula:

        Construtor da classe, possibilitando receber argumentos e inicializar atributos a partir da criação de um objeto;
        Com isso, a inicialização dos atributos recebidos no construtor torna-se obrigatória.
        Atributos da classe, os atributos estáticos;
        Métodos da classe, os métodos estáticos;
        Ausência de referência, do this, dentro de métodos estáticos.*/