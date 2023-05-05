using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.Repositorio.Classes
{
    public sealed class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly List<Produto> _lista = new List<Produto>()
        {
            new Produto()
            {
                CodigoBarra = "1001",
                Descricao = "Coca-Cola KS",
                Valor = 3.49m,
            },
            new Produto()
            {
                CodigoBarra = "1002",
                Descricao = "Coca-Cola Lata",
                Valor = 3.99m,
            },
        };

        public void Adicionar(Produto produto)
        {
            _lista.Add(produto);
        }

        public List<Produto> ObterTodos()
        {
            return _lista;
        }

        public void Remover(Produto produto)
        {
            _lista.Remove(produto);
        }
    }
}
