using EstudoInputOutput.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output


namespace EstudoInputOutput
{
    partial class Program // quando uso o "partial" eu digo que quero o mesmo arquivo dentro do mesmo projeto. Ou seja, tenho varias classes do mesmo arquivo.
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "conta.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream) // "EndOfStream" indica que nós chegamos no fim do Stream. O caractere ! indica negação, exemplo: enquanto não.
                {
                    var linha = leitor.ReadLine(); // leitor de Stream. "ReadLine()" ler linha por linha
                    var contaCorrente = ConverterStringParaContaCorrente(linha);
                    if (contaCorrente != null)
                        Console.WriteLine($"{contaCorrente.Titular.Nome} Conta número {contaCorrente.Numero} Ag. {contaCorrente.Agencia} Saldo {contaCorrente.Saldo}");
                }
            }
            Console.ReadLine();
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            if (string.IsNullOrEmpty(linha)) // Verifica se é nulo ou tem espaço.
            {
                return null;
            }

            var campos = linha.Split(','); //Splint vai quebrar a linha sempre que encontrar um espaço.

            var numero = campos[0];
            var agencia = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDoule = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDoule);
            resultado.Titular = titular;

            return resultado;
            
        }
    }
}
