using System;
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

        public async Task<List<Pedido>> ObterPorCodigoCliente(int codigoCliente)
        {
            return await _pedidoRepositoryEf.ObterPorCodigoCliente(codigoCliente);
        }

        public async Task<List<ItemPedido>> ObterItensPedido(int codigoPedido)
        {
            return await _pedidoRepositoryEf.ObterItensPedido(codigoPedido);
        }

        public async Task<List<ItemPedido>> ObterItensPedidoPorCodigos(List<int> codigos)
        {
            return await _pedidoRepositoryEf.ObterItensPedidoPorCodigos(codigos);
        }

        public async Task<List<Pedido>> ObterPedidos(DateTime dataIniciio, DateTime dataFim)
        {
            return await _pedidoRepositoryEf.ObterPedidos(dataIniciio, dataFim);
        }

        public async Task<List<Pedido>> ObterTodos()
        {
            return await _pedidoRepositoryEf.ObterTodos();
        }


    }
}
