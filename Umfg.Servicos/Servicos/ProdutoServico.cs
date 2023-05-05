using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.Aplicacao.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        public Produto Gravar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto ObterProdutoPorCodigoBarra(string codigoBarra)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void RemoverPorCodigoBarra(string codigoBarra)
        {
            throw new NotImplementedException();
        }
    }
}