using CentralDeProdutos.Domain.Models;
using CentralDeProdutos.Domain.Ports.Repositories;
using CentralDeProdutos.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Infra.Data.Repositories
{
    /// <summary>
    /// Repositório de dados para Produto
    /// </summary>
    public class ProdutoRepository : BaseRepository<Produto, Guid>, IProdutoRepository
    {
        private readonly DataContext? _dataContext;

        public ProdutoRepository(DataContext? dataContext)
            : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Produto> GetByCategoria(Guid categoriaId)
        {
            return _dataContext.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.CategoriaId == categoriaId)
                .ToList();
        }

        public override Produto GetById(Guid id)
        {
            return _dataContext.Produtos
                .Include(p => p.Categoria)
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
