using EstudoCsharp.Inheritance.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;


namespace EstudoCsharp.Inheritance.ParceirosDoTypebank
{
    public class ParceiroAdm : IAutenticar
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha) => Senha == senha;

    }
}
