using System;

namespace EstudoEntityFramework
{
    public class Compra
    {
        public int ID { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }
    }
}