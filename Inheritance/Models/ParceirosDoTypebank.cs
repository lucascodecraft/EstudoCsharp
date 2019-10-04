using EstudoCsharp.Inheritance.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;


namespace EstudoCsharp.Inheritance.ParceirosDoTypebank
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
