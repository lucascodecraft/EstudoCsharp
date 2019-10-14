using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EstudoCsharp.Inheritance.Funcionarios
{
    public class GerenciadorBonificacao
    {
        public List<Funcionario> Funcionarios { get; set; }

        public GerenciadorBonificacao()
        {
            Funcionarios = new List<Funcionario>(); 
        }

        public void Registrar(Funcionario funcionario) => Funcionarios.Add(funcionario);   // Adiciciona um funcionario na lista.

        public double GetTotalBonificacao() => Funcionarios.Sum(x => x.GetBonificacao()); // somando as bonificações dentro da lista
    }
}
