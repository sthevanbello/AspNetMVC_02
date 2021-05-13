using CasaDoCodigo.aula3.antes.Models.ViewModels;
using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.aula3.antes.Models
{
    public class UpdateQuantidadeResponse
    {

        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get;}
        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }
    }
}
