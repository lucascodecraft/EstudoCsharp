using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public abstract class Animal : IAnimal
    {
        public string Tipo { get; }
        public string Nome { get; }

        public Animal(string tipo, string nome)
        {
            Tipo = tipo;
            Nome = nome;
        }
         
        public virtual void Andar()
        {
            Console.WriteLine("Animal andou.");
        }

        public virtual void Saltar()
        {
            Console.WriteLine("Animal saltou.");
        }
    }
}
