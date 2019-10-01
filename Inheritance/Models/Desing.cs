using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCsharp.Inheritance.Funcionarios
{
    public class Desing : Funcionario
    {
        public Desing(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Desing");
        }
        public override void AumentarSalario() => Salario *= 1.05;

        public override double GetBonificacao() => Salario * 0.25;

    }
}
