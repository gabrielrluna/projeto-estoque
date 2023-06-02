using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using funcionarios.ClasseAbstrata;

namespace funcionarios.ClasseDerivada
{
    public class Mauricio : Funcionario
    {
        public override string Nome()
        {
            return "Maurício";
        }        
        public override string Funcao()
        {
            return "Controlador de Estoque";
        }

        public override double Salario()
        {
            return 1800.00;
        }

        public override void Atividade()
        {
            Console.WriteLine("O Funcionário está em licença médica.");
        }
    }
}