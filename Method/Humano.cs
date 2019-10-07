using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public class Humano : Animal
    {
        public string MododeAndar { get; set; }

        public Humano(string nome) : base("Humano", nome)
        {
            Console.WriteLine("Criando Humano");
        }
        public override void Saltar()
        {
            Console.WriteLine("Humano saltou.");
        }
        public override void Andar()
        {
            Console.WriteLine("Humano andou.");
            MododeAndar = "Andei de duas pernas";
        }
    }
}
