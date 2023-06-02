using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace polimorfismo.Interface
{
    
    public interface IProduto
    {
        void Encomendar();
        void Separar();
        bool ColocarNaGondola();
        void ConferirValidade();
    }
    
}