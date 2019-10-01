using EstudoCsharp.Inheritance.Funcionarios;
using EstudoCsharp.Inheritance.Sistemas;
using System;
using EstudoCsharp.Inheritance.ParceirosDoTypebank;


namespace EstudoCsharp.Inheritance
{
    class Program
    {
        private static SistemaInterno sistemaInterno;

        static void Main(string[] args)
        {
            CalcularBonificacao();
            UsarSistema();
            AumentarSalario();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            sistemaInterno = new SistemaInterno();
            Diretor lucas = new Diretor("542.253.545-85");
            lucas.Nome = "Lucas";
            lucas.Senha = "123";

            GerenteDeTi maria = new GerenteDeTi("545.263.245-52");
            maria.Nome = "Maria";
            maria.Senha = "254";

            var parceiro = new EstudoCsharp.Inheritance.ParceirosDoTypebank.ParceirosDoTypebank();
            parceiro.Nome = "Parceiro";
            parceiro.Senha = "542";

            sistemaInterno.Logar(lucas, "123");
            sistemaInterno.Logar(maria, "545");
            sistemaInterno.Logar(parceiro, "542");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Diretor lucas = new Diretor("545.584.252-85");
            lucas.Nome = "Lucas";

            Desing maria = new Desing("548.252.365-85");
            maria.Nome = "Maria";

            Auxiliar luiz = new Auxiliar("585.654.258-85");
            luiz.Nome = "Luiz";

            GerenteDeTi tirulipa = new GerenteDeTi("211.155.485-85");
            tirulipa.Nome = "Tirulipa";

            gerenciador.Registrar(lucas);
            gerenciador.Registrar(maria);
            gerenciador.Registrar(luiz);
            gerenciador.Registrar(tirulipa);

            Console.WriteLine("Total bonificação: "+gerenciador.GetTotalBonificacao());
     
        }

        public static void AumentarSalario()
        {

            Diretor lucas = new Diretor("545.584.252-85");
            lucas.Nome = "Lucas";

            Desing maria = new Desing("548.252.365-85");
            maria.Nome = "Maria";

            Auxiliar luiz = new Auxiliar("585.654.258-85");
            luiz.Nome = "Luiz";

            GerenteDeTi tirulipa = new GerenteDeTi("211.155.485-85");
            tirulipa.Nome = "Tirulipa";

            lucas.AumentarSalario();
            maria.AumentarSalario();
            luiz.AumentarSalario();
            tirulipa.AumentarSalario();

            Console.WriteLine(lucas.Salario);
            Console.WriteLine(maria.Salario);
            Console.WriteLine(luiz.Salario);
            Console.WriteLine(tirulipa.Salario);

        }
    }
}
