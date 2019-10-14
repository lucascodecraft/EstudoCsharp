using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoClasses
{
    public class Mamifero : Animal
    {
        public Mamifero(string nome) : base(nome)
        {
        }

        public void Mamar()
        {
            // Implementar rotina
        }

        public enum sexo { M = 1, F = 10}
    }
}
