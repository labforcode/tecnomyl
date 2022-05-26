using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Pedidos;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Services.Pedidos
{
    public class PedidoAppService : IPedidoAppService
    {
        private readonly IMapper _mapper;
        private readonly IPedidoComando _pedidoComando;
        private readonly IPedidoConsulta _pedidoConsulta;

        public PedidoAppService(IMapper mapper,
                                 IPedidoComando pedidoComando,
                                 IPedidoConsulta pedidoConsulta)
        {
            _mapper = mapper;
            _pedidoComando = pedidoComando;
            _pedidoConsulta = pedidoConsulta;
        }

        public void Adicionar(PedidoDto pedido)
        {
            var comandoPedido = _mapper.Map<Pedido>(pedido);
            var comandoItensPedido = _mapper.Map<List<ItemPedido>>(pedido.ItensPedido);

            _pedidoComando.Adicionar(comandoPedido, comandoItensPedido);
        }

        public void Atualizar(PedidoDto pedido)
        {
            var comandoPedido = _mapper.Map<Pedido>(pedido);
            var comandoItensPedido = _mapper.Map<List<ItemPedido>>(pedido.ItensPedido);

            _pedidoComando.Atualizar(comandoPedido, comandoItensPedido);
        }

        public void Excluir(PedidoDto pedido)
        {
            var comandoPedido = _mapper.Map<Pedido>(pedido);
            var comandoItensPedido = _mapper.Map<List<ItemPedido>>(pedido.ItensPedido);

            _pedidoComando.Excluir(comandoPedido, comandoItensPedido);
        }

        public async Task<PedidoViewModel> ObterPorId(int codigo)
        {
            return _mapper.Map<PedidoViewModel>(await _pedidoConsulta.ObterPorId(codigo));
        }

        public async Task<IEnumerable<PedidoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<PedidoViewModel>>(await _pedidoConsulta.ObterTodos());
        }
    }
}
