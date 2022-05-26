using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Pedidos
{
    public class PedidoRepositoryEf : BaseRepositoryEf<Pedido>, IPedidoRepositoryEf
    {
        public PedidoRepositoryEf(DbTecnomyl context) : base(context)
        {
        }

        public void AddItensPedido(List<ItemPedido> itensPedido)
        {
            try
            {
                Context.ItensPedido.AddRange(itensPedido);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Pedido> ObterPorId(int codigo)
        {
            try
            {
                return await Context.Pedidos.FirstOrDefaultAsync(w => w.Codigo == codigo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<Pedido>> ObterPorCodigoCliente(int codigoCliente)
        {
            try
            {
                return await Context.Pedidos.Where(w => w.CodigoCliente == codigoCliente).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<Pedido>> ObterPedidos(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                return await Context.Pedidos.Where(w => w.DataPedido >= dataInicio && w.DataPedido <= dataFim).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<ItemPedido>> ObterItensPedido(int codigoPedido)
        {
            try
            {
                return await Context.ItensPedido.Where(w => w.CodigoPedido == codigoPedido).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<ItemPedido>> ObterItensPedidoPorCodigos(List<int> codigos)
        {
            try
            {
                return await Context.ItensPedido.Where(w => codigos.Contains(w.CodigoPedido)).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<Pedido>> ObterTodos()
        {
            try
            {
                return await Context.Pedidos.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
