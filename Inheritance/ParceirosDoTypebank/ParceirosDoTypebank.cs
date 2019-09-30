using System;
using System.Collections.Generic;
using System.Text;
using typebank.Funcionarios;
using typebank.ParceirosDoTypebank;
using typebank.Sistemas;

namespace typebank.ParceirosDoTypebank
{
    public class ParceirosDoTypebank : ParceiroAdm, IAutenticar
    {
        public string Nome { get; set; }

        public ParceirosDoTypebank()
        {
            Console.WriteLine("Criando Parceiro");
        }

        public new bool Autenticar(string senha) => Senha.Equals(senha);
    }
}
