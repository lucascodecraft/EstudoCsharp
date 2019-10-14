using EstudoCsharp.Inheritance.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoCsharp.Inheritance.Funcionarios
{
     public class Diretor : FuncionarioAdm, IAutenticar
    {
        public Diretor(string cpf) : base(8000, cpf)
        {
            Console.WriteLine("Criando diretor");
        }
        public bool Autenticar(string senha) => Senha.Equals(senha);
         
        public override void AumentarSalario() => Salario *= 1.15;

        public override double GetBonificacao() => Salario * 0.5; // (override diz que o matodo vai subescrever o metodo da MÃE.)
    }
}
