using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using funcionarios.ClasseAbstrata;

namespace funcionarios.ClasseDerivada
{
    public class Marta : Funcionario
    {
        public override string Nome()
        {
            return "Marta";
        }        
        public override string Funcao()
        {
            return "Repositor";
        }

        public override double Salario()
        {
            return 1500.00;
        }

    }
}