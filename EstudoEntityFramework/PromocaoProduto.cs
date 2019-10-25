namespace EstudoEntityFramework
{
    public class PromocaoProduto
    {
        public int Id { get; set; }
        public int ProdutoId { get; internal set; }
        public Produto Produto { get; set; }
        public int PromocaoId { get; internal set; }
        public Promocao Promocao { get; set; }
    }
}