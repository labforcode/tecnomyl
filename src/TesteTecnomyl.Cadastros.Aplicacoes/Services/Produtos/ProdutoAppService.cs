using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Produtos;
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

        public ProdutoAppService(IMapper mapper,
                                 IProdutoComando produtoComando,
                                 IProdutoConsulta produtoConsulta)
        {
            _mapper = mapper;
            _produtoComando = produtoComando;
            _produtoConsulta = produtoConsulta;
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

        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoConsulta.ObterTodos());
        }
    }
}
