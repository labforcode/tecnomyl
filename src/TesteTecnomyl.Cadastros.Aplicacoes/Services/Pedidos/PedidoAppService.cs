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
            var comando = _mapper.Map<Pedido>(pedido);
        }

        public void Atualizar(PedidoDto pedido)
        {
            var comando = _mapper.Map<Pedido>(pedido);
        }

        public void Excluir(PedidoDto pedido)
        {
            throw new NotImplementedException();
        }

        public async Task<PedidoViewModel> ObterPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PedidoViewModel>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
