using System;
using System.Collections.Generic;

namespace EstudoLista
{
    class Program
    {
        public static void Main(string[] args)
        {
            TestandoListaDeInt();
            Console.WriteLine("=========");
            TestandoListaDeString();
        }

        static void TestandoListaDeInt()
        {
            var notas = new List<int>();

            notas.Add(5);
            notas.AdicionarVarios(2, 5, 4);
            notas.Sort();                            // Ordena as lista.

            for (var i = 0; i < notas.Count; i++)
            {
                Console.WriteLine(notas[i]);
            }
        }

        static void TestandoListaDeString()
        {
            var nomes = new List<string>()
            {
                "Victor" ,"Marcos", "Gesiel", "Lucas"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
