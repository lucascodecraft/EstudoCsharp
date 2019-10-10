using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public class Cachorro : Animal
    {
        public string MododeAndar { get; set; }
        public int TotaldeSaltos { get; set; }

        public Cachorro(string nome) : base("Cachorro", nome)
        {
            Console.WriteLine("Criando cachorro");
        }

        public override void Saltar()
        {
            Console.WriteLine("Cachorro saltou.");
            TotaldeSaltos++;
        }
         
        public override void Andar()
        { 
            Console.WriteLine("Cachorro andou.");
            MododeAndar = "Andei de quatro patas";
        }
        public override void Correr()
        {
            Console.WriteLine("cachorro correu");
        }

    }
}
