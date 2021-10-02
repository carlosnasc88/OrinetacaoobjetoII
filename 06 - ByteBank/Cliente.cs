using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__ByteBank
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }

            set
            {
                //Escro minha logica de validacao de CPF.
                _cpf = value;

            }

        }

        public string Profissao { get; set; }     
      




    }
}




        /*   Aprendemos nesta aula:

        Atributos privados, restringindo o acesso aos atributos
        Encapsulamento de código
        Métodos de leitura dos atributos, os getters
        Métodos de modificação dos atributos, os setters
        A sintaxe de propriedades no C# para facilitar a criação de getters e setters: public int Idade { get; set; }
        Getters e Setters de referência           */