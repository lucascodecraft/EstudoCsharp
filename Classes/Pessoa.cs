using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public abstract class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }

        public void Andar()
        {
            // Rotina
        }
        public abstract void Comer();

        public void Dormir()
        {
            //
        }

    }
}
