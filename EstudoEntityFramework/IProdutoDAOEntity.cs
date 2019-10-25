using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEntityFramework
{
    public interface IProdutoDAOEntity
    {
        void Adicionar(Produto produto);
        void Remover(Produto produto);
        void Atualizar(Produto produto);
        IList<Produto> Produtos();
    }
}
