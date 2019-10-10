using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoManipulacaoString
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; }
        public string Profissao { get; set; }

        public Pessoa(string cpf)
        {
            Console.WriteLine("criando pessoa.");

            CPF = cpf;
        }

        public override bool Equals(object obj)
        {
            if (obj is Pessoa pessoa)
                return CPF == pessoa.CPF;
                
            return false;
        }
        
        public override string ToString() // Esse método sobrescreve o metodo criado na classe "Object". Observação: todas as classes devriavam da classe object.
        {
            return $"Número do CPF {CPF}";
        }
    }
}
