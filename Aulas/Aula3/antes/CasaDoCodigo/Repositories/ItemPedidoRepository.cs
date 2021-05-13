using CasaDoCodigo.aula3.antes.Models;
using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
        void RemoveItemPedido(int itemPedidoId);
    }

    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            var item = dbSet.Where(i => i.Id == itemPedidoId).SingleOrDefault();

            return item;
        }

        public void RemoveItemPedido(int itemPedidoId)
        {
            var item = GetItemPedido(itemPedidoId);

            dbSet.Remove(item);
        }
    }
}
