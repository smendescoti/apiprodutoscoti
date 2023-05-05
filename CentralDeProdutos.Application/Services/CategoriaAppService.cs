using AutoMapper;
using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Application.Ports;
using CentralDeProdutos.Application.Queries;
using CentralDeProdutos.Domain.Interfaces;
using CentralDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Application.Services
{
    public class CategoriaAppService : ICategoriaAppService
    {
        private readonly ICategoriaDomainService? _categoriaDomainService;
        private readonly IMapper _mapper;

        public CategoriaAppService(ICategoriaDomainService? categoriaDomainService, IMapper mapper)
        {
            _categoriaDomainService = categoriaDomainService;
            _mapper = mapper;
        }

        public CategoriasQuery Add(CreateCategoriaCommand command)
        {
            var categoria = _mapper.Map<Categoria>(command);
            _categoriaDomainService.Add(categoria);

            return _mapper.Map<CategoriasQuery>(categoria);
        }

        public CategoriasQuery Update(UpdateCategoriaCommand command)
        {
            var categoria = _mapper.Map<Categoria>(command);
            _categoriaDomainService.Update(categoria);

            return _mapper.Map<CategoriasQuery>(categoria);
        }

        public CategoriasQuery Delete(DeleteCategoriaCommand command)
        {
            var categoria = _mapper.Map<Categoria>(command);
            _categoriaDomainService.Delete(categoria);

            return _mapper.Map<CategoriasQuery>(categoria);
        }

        public List<CategoriasQuery> GetAll()
        {
            var categorias = _categoriaDomainService.GetAll();
            return _mapper.Map<List<CategoriasQuery>>(categorias);
        }

        public CategoriasQuery GetById(Guid? id)
        {
            var categoria = _categoriaDomainService.GetById(id.Value);
            return _mapper.Map<CategoriasQuery>(categoria);
        }

        public void Dispose()
        {
            _categoriaDomainService.Dispose();
        }
    }
}
