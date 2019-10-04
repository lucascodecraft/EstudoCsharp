using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public class Cachorro : Animal, ISaltar
    {
        public int saltar { get; set; }
        public int Saltei { get; set; }
        public string MododeAndar { get; set; }
        public int TotaldeSaltos { get; set; }

        public Cachorro(string nome) : base("Cachorro", nome)
        {
            Console.WriteLine("Criando cachorro");
        }

        public void Saltar()
        {
            Console.WriteLine("Cachorro saltou.");
            TotaldeSaltos++;
            Saltei = saltar;
        }

        public override void Andar()
        {
            Console.WriteLine("Cachorro andou.");
            MododeAndar = "Andei de quatro patas";
        }
    }
}
