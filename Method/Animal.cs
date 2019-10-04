using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public abstract class Animal
    {
        public string Tipo { get; }
        public string Nome { get; }

        public Animal(string tipo, string nome)
        {
            Tipo = tipo;
            Nome = nome;
        }

        public abstract void Andar();
    }
}
