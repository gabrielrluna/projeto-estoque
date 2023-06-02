using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using funcionarios.ClasseAbstrata;

namespace funcionarios.ClasseDerivada
{
    public class Claudio : Funcionario
    {
        public override string Nome()
        {
            return "Cláudio";
        }        
        public override string Funcao()
        {
            return "Controlador de Estoque";
        }

        public override double Salario()
        {
            return 1800.00;
        }

    }
}