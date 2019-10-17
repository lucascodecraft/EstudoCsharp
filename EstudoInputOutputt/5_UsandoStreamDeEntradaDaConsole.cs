using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EstudoInputOutput
{
    partial class Program
    {
        static void UsarStremDeEntrada()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fileStream = new FileStream("contaCorrente.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                    fileStream.Write(buffer, 0, bytesLidos);
                    fileStream.Flush();
                    Console.WriteLine($"Número de bytes: {bytesLidos}");
                }
            }
        }
    }
}
