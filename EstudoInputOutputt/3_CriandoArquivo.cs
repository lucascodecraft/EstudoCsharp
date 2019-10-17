using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoInputOutput
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create)) // Criando um arquivo "FileStream", e colocando dentro da variavel fluxoDeArquivo.
            {
                var contaComoString = "456,78945,4785.50,Lucas Lima"; 
                var encoding = Encoding.UTF8; // 

                var bytes = encoding.GetBytes(contaComoString); // Método "GetBytes" devolve as String convertida em Bytes.

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))  
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8)) // Esse Encoding.UTF8, não é obrigatorio, apenas se quiser especificar o Encoding.  
                                                                                   // StreamWriter não precisa lidar com Bytes, ele transforma uma string em um arquivo de forma simplificada
            {
                escritor.Write("456,65465,456.0,Lucas"); // Escrevendo o arquivo 
                Console.WriteLine(escritor);
            }
        }

        static void TesteEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); // O método Flush ele despeja o buffer para FileStream. sem o método Flush, teria uma demora enorme no envio das informações para o "FileStream".
                    Console.WriteLine($"Linha {i}. Essa linha foi escrita, tecle enter para continuar");
                    Console.ReadLine();
                }
            }
        }
    }
}
