﻿namespace EstudoEntityFramework
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; internal set; }
        public Endereco EnderecoDeEntrega { get; internal set; }
    }
}