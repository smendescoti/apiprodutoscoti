using CentralDeProdutos.Application.Ports;
using CentralDeProdutos.Application.Services;
using CentralDeProdutos.Domain.Interfaces;
using CentralDeProdutos.Domain.Ports.Repositories;
using CentralDeProdutos.Domain.Services;
using CentralDeProdutos.Infra.Data.Contexts;
using CentralDeProdutos.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Services.Api.Setups
{
    /// <summary>
    /// Configuração para Injeção de dependência
    /// </summary>
    public class DependencyInjectionSetup
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            #region Application

            builder.Services.AddTransient<ICategoriaAppService, CategoriaAppService>();
            builder.Services.AddTransient<IProdutoAppService, ProdutoAppService>();

            #endregion

            #region Domain

            builder.Services.AddTransient<ICategoriaDomainService, CategoriaDomainService>();
            builder.Services.AddTransient<IProdutoDomainService, ProdutoDomainService>();

            #endregion

            #region Repositories

            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<DataContext>();

            #endregion
        }
    }
}
