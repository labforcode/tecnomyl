using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Consultas.Pedidos
{
    public class PedidoConsulta : IPedidoConsulta
    {
        private readonly IPedidoRepositoryEf _pedidoRepositoryEf;

        public PedidoConsulta(IPedidoRepositoryEf pedidoRepositoryEf)
        {
            _pedidoRepositoryEf = pedidoRepositoryEf;
        }

        public async Task<Pedido> ObterPorId(int codigo)
        {
            return await _pedidoRepositoryEf.ObterPorId(codigo);
        }

        public async Task<IEnumerable<Pedido>> ObterTodos()
        {
            return await _pedidoRepositoryEf.ObterTodos();
        }
    }
}
