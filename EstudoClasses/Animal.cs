using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public void Acordar()
        {
            // Implementar rotina;
        }

        public void Comer()
        {
            // Implemantar rotina;
        }

        public void Dormir()
        {
            //Implementar rotina;
        }

       
    }
}
