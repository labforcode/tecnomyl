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
        }

        public void Atualizar(ProdutoDto produto)
        {
            var comando = _mapper.Map<Produto>(produto);
        }

        public void Excluir(ProdutoDto produto)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoViewModel> ObterPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
