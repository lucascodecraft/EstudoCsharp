using System;
using System.Text.RegularExpressions;

namespace EstudoManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "banco";
            string plural = texto1.GerenciadorPlural();

            string texto2 = "Louco";
            string plural2 = texto2.GerenciadorPlural();

            Console.WriteLine(plural);
            Console.WriteLine(plural2);

            Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            var lucas_1 = new Pessoa("253.215.625-85");
            lucas_1.Nome = "Lucas";
            lucas_1.Profissao = "Desenvolvedor";

            var lucas_2 = new Pessoa("253.215.625-85");
            lucas_2.Nome = "Lucas";
            lucas_2.Profissao = "Desenvolvedor";

            if (lucas_1.Equals(lucas_2))
                Console.WriteLine("São iguais!");
            else
                Console.WriteLine("Não são iguais!");
            
            Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            var conta = new Pessoa("254.256.142-85");
            string contaToStringCPF = conta.ToString(); // chamando o método "ToString" que retorna no Console.writeLine o valor descrito no método

            Console.WriteLine(contaToStringCPF);
            Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string padrao6 = "[0-9]{4,5}-{0,1}[0-9]{0,4}";
            string testeDeManipulacao6 = "Meu número de fone é 55245-5458";

            Match resultado6 = Regex.Match(testeDeManipulacao6, padrao6);

            Console.WriteLine("Número: " + resultado6);
            Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string padrao5 = "[0-9]{4,7}[-][0-9]{4,5}"; // [0-9]{4,5}, estou dizendo que quero do caractere 0 até 9, e ele pode ter de quatro a cinco caracteres.
            string testeDeManipulacao5 = "Meu número é 8598854-6523";

            Match resultado5 = Regex.Match(testeDeManipulacao5, padrao5);

            Console.WriteLine("O número é "+ resultado5.Value);
            Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string padrao4 = "[0-9]{4}[-][0-9]{4}"; // [0-9]{4}, estou dizendo que quero do caractere 0 até 9, quatro vezes.
            string testeDeManipulacao4 = "Meu número é 5496-3112";

            Match resultado4 = Regex.Match(testeDeManipulacao4, padrao4);

            Console.WriteLine("O número é: "+ resultado4.Value);
            Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string padrao3 = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"; // [0-9], estou dizendo que quero do caractere 0 até 9.
            string testeDeManipulacao3 = "Meu número é 5415-5215";

            Match resultado3 = Regex.Match(testeDeManipulacao3, padrao3);

            Console.WriteLine("Meu número é: " + resultado3.Value);
            Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string padrao2 = "[lucas][lucas][lucas][lucas][lucas][-][lima][lima][lima][lima][0123456789][0123456789]";
            string testeDeManipulacao2 = "Meu usuario é lucas-lima10";

            Match resultado1 = Regex.Match(testeDeManipulacao2, padrao2);

            Console.WriteLine(resultado1.Value);
            Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string padrao1 = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"; // Se o número conter um espaço o padrão deve ser respeitado e um espaço invés do [-]
            string testeDeManipulacao1 = "Meu nome é Lucas e meu telefone é 8594-5356";

            Match resultado = Regex.Match(testeDeManipulacao1, padrao1); //  "Regex.Match" ver se a string contem o padrão. Retorna o texto

            Console.WriteLine("O número de telefone é: "+ resultado.Value);
            Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string testeDeManipulacao = "Meu nome é Lucas e meu telefone é 8594-5356";

            Regex.IsMatch(testeDeManipulacao, padrao); // "Regex.IsMatch" ver se a string passada contem o padrão. Retorna sempre True or False.

            Console.WriteLine("Existe esse padrão dentro da string? : " + Regex.IsMatch(testeDeManipulacao, padrao));

            Console.ReadLine();
        }
    }
}
