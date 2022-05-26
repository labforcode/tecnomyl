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

        public async Task<IEnumerable<Pedido>> ObterTodos()
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
