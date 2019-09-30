using POO.Inheritance.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;


namespace POO.Inheritance.ParceirosDoTypebank
{
    public class ParceiroAdm : IAutenticar
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha) => Senha == senha;

    }
}
