using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Services.Api.Setups
{
    /// <summary>
    /// Configuração para a política de CORS
    /// </summary>
    public class CorsSetup
    {
        private static string? policyName = "DefaultPolicy";

        public static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddCors(
                   s => s.AddPolicy(policyName, builder =>
                   {
                       /*
                       builder.WithOrigins("http://meuservidor.com.br", "", "")
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                       */

                       builder.AllowAnyOrigin() //qualquer origem pode acessar a API
                              .AllowAnyMethod() //qualquer método (POST, PUT, DELETE, GET)
                              .AllowAnyHeader(); //qualquer informação de cabeçalho
                   })
               );
        }

        public static void Use(WebApplication app)
        {
            app.UseCors(policyName);
        }
    }
}
