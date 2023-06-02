using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using funcionarios.ClasseAbstrata;

namespace funcionarios.ClasseDerivada
{
    public class Silvana : Funcionario
    {
        public override string Nome()
        {
            return "Carlos";
        }        
        public override string Funcao()
        {
            return "Chefe de Setor";
        }

        public override double Salario()
        {
            return 2500.00;
        }

    }
}