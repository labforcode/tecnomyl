using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Produtos;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Services.Pedidos
{
    public class PedidoAppService : IPedidoAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteAppService _clienteAppService;
        private readonly IProdutoConsulta _produtoConsulta;
        private readonly IPedidoComando _pedidoComando;
        private readonly IPedidoConsulta _pedidoConsulta;

        public PedidoAppService(IMapper mapper,
                                IClienteAppService clienteAppService,
                                IProdutoConsulta produtoConsulta,
                                IPedidoComando pedidoComando,
                                IPedidoConsulta pedidoConsulta)
        {
            _mapper = mapper;
            _clienteAppService = clienteAppService;
            _produtoConsulta = produtoConsulta;
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
            var pedido = _mapper.Map<PedidoViewModel>(await _pedidoConsulta.ObterPorId(codigo));

            pedido = await TratarPedido(pedido);

            return pedido;
        }

        public async Task<List<PedidoViewModel>> ObterPorCodigoCliente(int codigoCliente)
        {
            var pedidos = _mapper.Map<List<PedidoViewModel>>(await _pedidoConsulta.ObterPorCodigoCliente(codigoCliente));
            var pedidosAtualizados = new List<PedidoViewModel>();
            foreach (var pedido in pedidos)
            {
                var pedidoAtualizado = await TratarPedido(pedido);
                pedidosAtualizados.Add(pedidoAtualizado);
            }

            return pedidosAtualizados;
        }

        public async Task<List<PedidoViewModel>> ObterPedidos(DateTime dataInicio, DateTime dataFim)
        {
            var pedidos = _mapper.Map<List<PedidoViewModel>>(await _pedidoConsulta.ObterPedidos(dataInicio, dataFim));
            var pedidosAtualizados = new List<PedidoViewModel>();
            foreach (var pedido in pedidos)
            {
                var pedidoAtualizado = await TratarPedido(pedido);
                pedidosAtualizados.Add(pedidoAtualizado);
            }

            return pedidosAtualizados;
        }

        public async Task<List<PedidoViewModel>> ObterTodos()
        {
            var pedidos = _mapper.Map<List<PedidoViewModel>>(await _pedidoConsulta.ObterTodos());
            var pedidosAtualizados = new List<PedidoViewModel>();
            foreach (var pedido in pedidos)
            {
                var pedidoAtualizado = await TratarPedido(pedido);
                pedidosAtualizados.Add(pedidoAtualizado);
            }

            return pedidosAtualizados;
        }

        private async Task<PedidoViewModel> TratarPedido(PedidoViewModel pedido)
        {
            var cliente = await _clienteAppService.ObterPorId(pedido.CodigoCliente);
            pedido.NomeCliente = cliente.Nome;
            pedido.ItensPedido = await ObterItensPedido(pedido.Codigo);

            return pedido;
        }

        private async Task<List<ItemPedidoViewModel>> ObterItensPedido(int codigoPedido)
        {
            var itens = _mapper.Map<List<ItemPedidoViewModel>>(await _pedidoConsulta.ObterItensPedido(codigoPedido));

            foreach (var item in itens)
            {
                var produto = await _produtoConsulta.ObterPorId(item.CodigoProduto);
                item.NomeProduto = produto.Nome;
            }

            return itens;
        }

        public async Task<List<ItemPedidoViewModel>> ObterItensPedidoPorCodigos(List<int> codigos)
        {
            return _mapper.Map<List<ItemPedidoViewModel>>(await _pedidoConsulta.ObterItensPedidoPorCodigos(codigos));
        }
    }
}
