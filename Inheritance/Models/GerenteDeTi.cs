﻿using EstudoCsharp.Inheritance.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;


namespace EstudoCsharp.Inheritance.Funcionarios
{
    public class GerenteDeTi : FuncionarioAdm, IAutenticar
    {
        public GerenteDeTi(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando gerente");  
        }

        public override void AumentarSalario() => Salario *= 1.80;

        public bool Autenticar(string senha) => Senha.Equals(senha);
        
        public override double GetBonificacao() => Salario * 0.15;

    }
}
