using CasaDoCodigo.aula2.antes.Models.ViewModels;
using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.aula2.antes.Models
{
    public class UpdateQuantidadeResponse
    {
        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }

        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get; }
    }
}
