using AutoMapper;
using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Application.Mappings
{
    public class CommandToModelMap : Profile
    {
        public CommandToModelMap()
        {
            CreateMap<CreateCategoriaCommand, Categoria>()
                .AfterMap((command, model) =>
                {
                    model.Id = Guid.NewGuid();
                });

            CreateMap<CreateProdutoCommand, Produto>()
                .AfterMap((command, model) => 
                {
                    model.Id = Guid.NewGuid();
                });

            CreateMap<DeleteCategoriaCommand, Categoria>();
            CreateMap<DeleteProdutoCommand, Produto>();

            CreateMap<UpdateCategoriaCommand, Categoria>();
            CreateMap<UpdateProdutoCommand, Produto>();
        }
    }
}
