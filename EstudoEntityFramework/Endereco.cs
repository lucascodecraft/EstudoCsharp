namespace EstudoEntityFramework
{
    public class Endereco
    {
        public string Complemento { get; internal set; }
        public string Bairro { get; internal set; }
        public string Rua { get; internal set; }
        public int Numero { get; internal set; }
        public Cliente Cliente { get; set; }
    }
}