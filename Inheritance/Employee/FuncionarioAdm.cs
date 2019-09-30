using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Inheritance.Funcionarios
{
    public abstract class FuncionarioAdm : Funcionario
    {
        public FuncionarioAdm(double salario, string cpf) : base(salario, cpf)
        {
        }
        public string Senha { get; set; }


    }
}
