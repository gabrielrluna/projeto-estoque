using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.ProdutosBase
{
    public class Produto
    {
        public string? Marca {get; set;}
        public void Ativo ()
        {
            Console.WriteLine("O produto está ativo no mercado");
        }

    }

}