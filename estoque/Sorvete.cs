using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoque
{
    //"QuantSorvete" serve para saber a quantidade de sorvete disponível em estoque
    //"DiaChecagem" serve para definir o dia de chegagem do estoque
    public record Sorvete(int QuantSorvete, int DiaChecagem)
    {
        //"QuantSorvete" serve para saber a quantidade de sorvete disponível em estoque
        public int QuantSorvete { get; private set; } = QuantSorvete;

        //"DiaChecagem" serve para definir o dia de chegagem do estoque
        public int DiaChecagem { get; private set; } = DiaChecagem;

        public void VendaSorvete(int sorvetesVendidos)
        {

            //Validação para avisar que a quantidade em estoque está acabando e é necessário comprar mais.
            if (QuantSorvete < 40)
            {
                Console.WriteLine("Aviso! O estoque está acabando!");

                //Validação para evitar uma compra "negativa" ou para evitar que um produto seja vendido sem estoque
                if (sorvetesVendidos < 0){
                    Console.WriteLine("Valor não aceito");
                } else if (QuantSorvete < 1){
                    Console.WriteLine("Não há sorvetes disponíveis para venda no estoque");
                } else if (sorvetesVendidos > QuantSorvete){
                    Console.WriteLine("Não há essa quantidade disponível para venda no estoque");
                } else {
                    QuantSorvete -= sorvetesVendidos;
                }
            }

        }

        public void ReposicaoSorvete(int sorvetesComprados)
        {
            QuantSorvete += sorvetesComprados;
        }


        public void PerdaSorvete(int sorvetesPerdidos)
        {
            QuantSorvete -= sorvetesPerdidos;
        }

        public void AlterarDiaChecagem(int novoDia)
        {
            this.DiaChecagem = novoDia;
        }
    }
}

