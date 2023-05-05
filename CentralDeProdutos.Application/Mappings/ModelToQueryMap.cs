using AutoMapper;
using CentralDeProdutos.Application.Queries;
using CentralDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Application.Mappings
{
    public class ModelToQueryMap : Profile
    {
        public ModelToQueryMap()
        {
            CreateMap<Categoria, CategoriasQuery>();
            CreateMap<Produto, ProdutosQuery>();
        }
    }
}
