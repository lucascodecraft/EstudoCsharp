using System;
using System.Collections.Generic;
using System.Text;
using typebank.Sistemas;

namespace typebank.ParceirosDoTypebank
{
    public class ParceiroAdm : IAutenticar
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha) => Senha == senha;

    }
}
