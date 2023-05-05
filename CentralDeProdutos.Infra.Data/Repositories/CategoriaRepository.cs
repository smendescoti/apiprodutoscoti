using CentralDeProdutos.Domain.Models;
using CentralDeProdutos.Domain.Ports.Repositories;
using CentralDeProdutos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Infra.Data.Repositories
{
    /// <summary>
    /// Repositório de dados para Categoria
    /// </summary>
    public class CategoriaRepository : BaseRepository<Categoria, Guid>, ICategoriaRepository
    {
        private readonly DataContext? _dataContext;

        public CategoriaRepository(DataContext? dataContext) 
            : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
