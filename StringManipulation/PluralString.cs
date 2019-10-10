using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoManipulacaoString
{
    public static class PluralString
    {
        public static string GerenciadorPlural(this string texto) // Colocando a palavra reservada "this", estou permitindo que outra classe consiga chamar esse método sem precisar passar primeiro a Classe.
        {                                                    // Exemplo: texto.StringPlural().
            if (texto.EndsWith("s"))
                return texto;
            else
                return $"{texto}s";
        }

    }
}
