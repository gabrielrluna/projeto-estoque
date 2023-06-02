using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using heranca.ProdutosBase;

namespace heranca.ProdutosDerivada
{
    public class Sabonete : Produto
    {
        public int Id {get; set;}
        public string? Aroma {get; set;}
    }
}