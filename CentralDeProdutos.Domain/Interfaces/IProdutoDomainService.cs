using CentralDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Domain.Interfaces
{
    public interface IProdutoDomainService : IBaseDomainService<Produto, Guid>
    {
        List<Produto> GetByCategoria(Guid categoriaId);
    }
}
