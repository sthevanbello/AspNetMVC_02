using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.aula3.antes.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public IList<ItemPedido> Itens { get; }


        public CarrinhoViewModel(IList<ItemPedido> itens)
        {
            Itens = itens;
        }
        public decimal Total => Itens.Sum(i => i.Subtotal);


    }
}
