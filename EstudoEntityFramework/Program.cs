using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEntityFramework {
    partial class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();

            cliente.Nome = "Lucas";
            cliente.EnderecoDeEntrega = new Endereco()
            {
                Rua = "travessa",
                Bairro = "messejana",
                Complemento = "proximo",
                Numero = 451,
            };
  
            using (var contexto = new LojaContext())
            {
                var clientes = contexto.Clientes.Include(c => c.EnderecoDeEntrega).ToList();

                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());
            } 

            Console.WriteLine("Tecle enter para sair!");
            Console.ReadLine();
        }

        private static void MuitosParaMuitos()
        {
            var p1 = new Produto() { Nome = "Laranja", Categoria = "Alimento", Unidade = "kg", PrecoUnitario = 2.23 };
            var p2 = new Produto() { Nome = "Sabonete", Categoria = "Limpeza", Unidade = "Unidade", PrecoUnitario = 1.12 };
            var p3 = new Produto() { Nome = "Leite", Categoria = "Alimento", Unidade = "Kg", PrecoUnitario = 4.21 };

            var promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Pascoa Feliz";
            promocaoPascoa.DataInicio = DateTime.Now;
            promocaoPascoa.DataTermino = DateTime.Now.AddDays(5);

            promocaoPascoa.IncluiProduto(p1);
            promocaoPascoa.IncluiProduto(p2);
            promocaoPascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                contexto.Promocoes.Add(promocaoPascoa);
                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());
            }
        }

        private static void CompraPaoTeste()
        {
            var paoFrances = new Produto();
            paoFrances.Nome = "Pão Francês";
            paoFrances.PrecoUnitario = 0.40;
            paoFrances.Unidade = "unidade";
            paoFrances.Categoria = "Padaria";

            var compras = new Compra();
            compras.Quantidade = 50;
            compras.Preco = paoFrances.PrecoUnitario * compras.Quantidade;
            compras.Produto = paoFrances;

            using (var contexto = new LojaContext())
            {
                contexto.Compras.Add(compras);
                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());
            }
        }

        private static void AdicionarProduto()
        {
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();
                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }

                var novoProduto = new Produto()
                {
                    Nome = "Velozes e Furiosos",
                    Categoria = "Filme",
                    PrecoUnitario = 49.90
                };
                contexto.Produtos.Add(novoProduto);

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());
            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entry)
        {
            Console.WriteLine("=================");
            foreach (var e in entry)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }

        private static void AtualizarProduto()
        {
            GravarUsandoEntity();
            RecuperarProdutos();

            using (var repositorio = new ProdutoDAOEntity()) // Criando a instância de "LojaContext()"
            {
                Produto primeiro = repositorio.Produtos().First(); // variavel "primeiro", recebe a primeira linha da tabela "produtos"
                primeiro.Nome = "Senhor dos aneis -- Atualizado"; // Alterando o nome.
                repositorio.Atualizar(primeiro);// Chamando o "UPDATE", 
            }
            RecuperarProdutos();
        }

        private static void ExcluirProduto()
        {
            using (var repositorio = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repositorio.Produtos(); // faz o SELECT

                foreach (var item in produtos)
                {
                    repositorio.Remover(item); // Remover produto de dentro do repositorio.
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repositorio = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repositorio.Produtos();  // Faz a função do SELECT

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                    Console.WriteLine(item.PrecoUnitario);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            var p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.PrecoUnitario = 19.89;

            var novoP = new Produto();
            novoP.Nome = "Loucos por nescau";
            novoP.Categoria = "GFDHD";
            novoP.PrecoUnitario = 151;

            var novo5 = new Produto();
            novo5.Nome = "Mais pesado que o céu";
            novo5.Categoria = "Livros";
            novo5.PrecoUnitario = 120.85; 
            
            var novo6 = new Produto();
            novo6.Nome = "Clean code";
            novo6.Categoria = "Livros";
            novo6.PrecoUnitario = 80.0; 
            
            var novo7 = new Produto();
            novo7.Nome = "Pense em python";
            novo7.Categoria = "Livros";
            novo7.PrecoUnitario = 90.85; 
            
            var novo8 = new Produto();
            novo8.Nome = "Boas praticas";
            novo8.Categoria = "Livros";
            novo8.PrecoUnitario = 40.85; 
            
            var novo9 = new Produto();
            novo9.Nome = "Slash: Parece exagerado";
            novo9.Categoria = "Livros";
            novo9.PrecoUnitario = 50.85;

            using (var repositorio = new ProdutoDAOEntity())
            {
                repositorio.Adicionar(p);
                repositorio.Adicionar(novo5);
                repositorio.Adicionar(novo6);
                repositorio.Adicionar(novo7);
                repositorio.Adicionar(novo8);
                repositorio.Adicionar(novo9);
                repositorio.Adicionar(novoP);
            }
        }
    }
}
    

