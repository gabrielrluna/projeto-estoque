using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace funcionarios.ClasseAbstrata
{
    public abstract class Funcionario
    {
        public abstract string? Nome();
        public abstract string? Funcao();
        public abstract double Salario();
        public virtual void Atividade ()
        {
            Console.WriteLine("O funcionário está em exercício pleno da função");
        }


    }

}