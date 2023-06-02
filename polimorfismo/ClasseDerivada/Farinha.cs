using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using polimorfismo.Interface;

namespace polimorfismo.ClasseDerivada
{
    public class Farinha : IProduto
    {
        public int QtdGondola {get; set;}
        public bool ColocarNaGondola()
        {
            if(QtdGondola > 30){
                return true;
            } else {
                return false;
            }            
        }

        public void ConferirValidade()
        {
            Console.WriteLine("Conferir semanalmente a validade dos produtos nas gôndolas");
        }

        public void Encomendar()
        {
            Console.WriteLine("Conferir quantidade disponível em estoque mensalmente para fazer os pedidos");
        }

        public void Separar()
        {
            Console.WriteLine("Separar pedidos de encomenda antecipada");
        }
    }
}