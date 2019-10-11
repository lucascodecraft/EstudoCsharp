using System;

namespace EstudoList
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void TestaArrayDouble()
        {
            /*Um ARRAY é muito limitado, exemplo: se eu disse que o array tem 3 posições, eu não consigo adicionar algo em tempo de execução */

            var notas = new int[4] { 5, 8, 6, 10 };
            
            var acumuladorDeNotas = 0;
            foreach (var item in notas) // para cada item dentro da array "notas", 
                acumuladorDeNotas += item; // acumuladorDeNotas += item.

            var media = acumuladorDeNotas / notas.Length;

            Console.WriteLine($"Media das notas: {media.ToString("f")}");
            Console.WriteLine($"O tamanho da lista é: {notas.Length}"); // .Length mostra o tamanho de algo.

            //Decimal ValorEmReais = Decimal.Parse("5115,55");
            //ValorEmReais = Decimal.Floor(ValorEmReais);
            Console.ReadLine();
        }
    }
}
