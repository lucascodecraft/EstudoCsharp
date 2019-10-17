using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EstudoInputOutput
{
    partial class Program
    {
        static void EscritorBinaria()
        {
            using (var fileStream = new FileStream("ContaCorrente.txt", FileMode.Create))
            using (var escritor =  new BinaryWriter(fileStream)) // Criando um arquivo binario, com o "BinaryWriter".
            {
                escritor.Write(112); // Agencia
                escritor.Write(151151); // Numero da conta
                escritor.Write(1122.5); // saldo
                escritor.Write("Lucas Lima"); // Titular
            }
        }
        
        static void LeitorBinario()
        {
            using (var fileStream = new FileStream("ContaCorrente.txt", FileMode.Open)) // Abrindo o arquivo binario.
            using (var leitor = new BinaryReader(fileStream))
            {
                var agencia = leitor.ReadInt32(); // Lendo arquivo bilario
                var numero = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Titular da conta: {titular} Agencia: {agencia} Numero da conta {numero} Saldo: {saldo}");
            }
        }
    }
}
