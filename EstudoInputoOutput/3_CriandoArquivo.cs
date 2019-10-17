using EstudoInputOutput.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output

namespace EstudoInputOutput
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo,FileMode.Create))
            {
                var contaComoString = "252,52582,2546.5,lucas lima";
                var enconding = Encoding.UTF8;

                var bytes = enconding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriandoArquivoComWriter()
        {
            var caminhoDoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDoArquivo = new FileStream(caminhoDoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo))
            {
                escritor.Write("242,52545,2521.2, Lucas Lima");
            }
        }

        static void TestandoEscrita()
        {
            var caminhoDoArquivo = "texto.txt";

            using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo))
            {
                for (int i = 0; i < 10000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    Console.ReadLine();
                }
            }
        }
    }
}
