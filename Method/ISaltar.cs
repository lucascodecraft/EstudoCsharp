using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public interface ISaltar
    {
        public int saltar { get; set; }
        public int Saltei { get; set; }
        public int TotaldeSaltos { get; set; }
        void Saltar(); 
    }
}
