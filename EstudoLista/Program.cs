using System;
using System.Collections.Generic;

namespace EstudoLista
{
    class Program
    {
        public static void Main(string[] args)
        {
            TestandoListaDeInt();
            TestandoListaDeString();
        }

        static void TestandoListaDeInt()
        {
            var notas = new List<int>();

            notas.Add(5);
            notas.AdicionarVarios(2, 5);

            for (var i = 0; i < notas.Count; i++)
            {
                Console.WriteLine(notas[i]);
            }
        }

        static void TestandoListaDeString()
        {
            var nomes = new List<string>();

            nomes.Add("Lucas");

            nomes.AdicionarVarios("Victor", "Gesiel");

            for (var i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
