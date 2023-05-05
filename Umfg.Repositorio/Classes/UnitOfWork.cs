using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Interfaces;

namespace Umfg.Repositorio.Classes
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        public IProdutoRepositorio ProdutoRepositorio { get; private set; }

        public UnitOfWork(IProdutoRepositorio produtoRepositorio)
        {
            ProdutoRepositorio = produtoRepositorio;
        }
    }
}