using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCsharp.Inheritance.Funcionarios
{
    public abstract class FuncionarioAdm : Funcionario
    {
        public FuncionarioAdm(double salario, string cpf) : base(salario, cpf)
        {
        }
        public string Senha { get; set; }
    }
}
