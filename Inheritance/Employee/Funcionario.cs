using System;
using System.Collections.Generic;
using System.Text;

namespace typebank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotaldeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf )
        {
            Console.WriteLine("Criando funcionario");

            CPF = cpf;
            Salario = salario;

            TotaldeFuncionario++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao(); //(virtual) permite que uma classe filha subescreva o metodo.
                                                //(abstract) ele diz que as classes filhas *DEVEM* sobrescrever o metodo.
    }
}
