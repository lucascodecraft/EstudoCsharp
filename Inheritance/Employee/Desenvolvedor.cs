﻿using System;
using System.Collections.Generic;
using System.Text;

namespace typebank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(4500, cpf)
        {
            Console.WriteLine("Criando Dev");
        }

        public override void AumentarSalario() => Salario *= 1.04;

        public override double GetBonificacao() => Salario * 0.20;

    }

}
