using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoLista
{
    public static class ListaExtensao
    {
        public static void AdicionarVarios<T>(this List<T> ListaDeInteiros, params T[] itens) => ListaDeInteiros.AddRange(itens); // Criando um método generico adicionando o <T>,
                                                                                                                                  // Com o "params", eu consigo passar varios parametros em um metodo. 
    }
}
