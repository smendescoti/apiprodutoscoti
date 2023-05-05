using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Application.Commands
{
    public class CreateCategoriaCommand
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
