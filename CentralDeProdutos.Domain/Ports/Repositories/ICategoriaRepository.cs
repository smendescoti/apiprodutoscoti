using CentralDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Domain.Ports.Repositories
{
    public interface ICategoriaRepository : IBaseRepository<Categoria, Guid>
    {

    }
}
