using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Produtos;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Produtos;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Produtos;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Services.Produtos
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IMapper _mapper;
        private readonly IProdutoComando _produtoComando;
        private readonly IProdutoConsulta _produtoConsulta;
        private readonly IPedidoAppService _pedidoAppService;

        public ProdutoAppService(IMapper mapper,
                                 IProdutoComando produtoComando,
                                 IProdutoConsulta produtoConsulta,
                                 IPedidoAppService pedidoAppService)
        {
            _mapper = mapper;
            _produtoComando = produtoComando;
            _produtoConsulta = produtoConsulta;
            _pedidoAppService = pedidoAppService;
        }

        public void Adicionar(ProdutoDto produto)
        {
            var comando = _mapper.Map<Produto>(produto);
            _produtoComando.Adicionar(comando);
        }

        public void Atualizar(ProdutoDto produto)
        {
            var comando = _mapper.Map<Produto>(produto);
            _produtoComando.Atualizar(comando);
        }

        public void Excluir(ProdutoDto produto)
        {
            var comando = _mapper.Map<Produto>(produto);
            _produtoComando.Excluir(comando);
        }

        public async Task<ProdutoViewModel> ObterPorId(int codigo)
        {
            return _mapper.Map<ProdutoViewModel>(await _produtoConsulta.ObterPorId(codigo));
        }

        public async Task<ProdutoValorMedioViewModel> ObterValorMedioVendaProdutoUltimosDozeMesesAsync(int codigoProduto)
        {
            var dataInicio = new DateTime((DateTime.Now.Year - 1), DateTime.Now.Month, DateTime.Now.Day);
            var dataFim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(1).AddMilliseconds(-1);

            var produto = await _produtoConsulta.ObterPorId(codigoProduto);

            var pedidos = await _pedidoAppService.ObterPedidos(dataInicio, dataFim);
            var codigosPedido = pedidos.Select(s => s.Codigo).ToList();
            var itensPedidos = await _pedidoAppService.ObterItensPedidoPorCodigos(codigosPedido);
            var itensPedidosFiltradoPorProduto = itensPedidos.Where(w => w.CodigoProduto == codigoProduto).ToList();
            var valorMedio = itensPedidosFiltradoPorProduto.Sum(s => s.Valor) / 12;
            var produtoValorMedio = new ProdutoValorMedioViewModel
            {
                Codigo = codigoProduto,
                Nome = produto.Nome,
                ValorMedio = valorMedio
            };

            return produtoValorMedio;
        }

        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoConsulta.ObterTodos());
        }
    }
}
