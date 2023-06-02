using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using heranca.ProdutosBase;

namespace heranca.ProdutosDerivada
{
    public class Bolacha : Produto
    {
        public int Id {get; set;}
        public string? Tipo {get; set;}
        public string? Sabor {get; set;}
    }
}