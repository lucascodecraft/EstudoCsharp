using System;
using System.Collections.Generic;
using System.Text;

namespace typebank.Funcionarios
{
    public abstract class FuncionarioAdm : Funcionario
    {
        public FuncionarioAdm(double salario, string cpf) : base(salario, cpf)
        {
        }
        public string Senha { get; set; }

    }
}
