using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.UoW;

namespace TesteTecnomyl.Cadastros.Dominios.Comandos.Produtos
{
    public class ProdutoComando : IProdutoComando
    {
        private readonly IUnitOfWork _uow;
        private readonly IProdutoRepositoryEf _produtoRepositoryEf;

        public ProdutoComando(IUnitOfWork uow,
                              IProdutoRepositoryEf produtoRepositoryEf)
        {
            _uow = uow;
            _produtoRepositoryEf = produtoRepositoryEf;
        }

        public void Adicionar(Produto produto)
        {
            _produtoRepositoryEf.Add(produto);
            _uow.Commit();
        }

        public void Atualizar(Produto produto)
        {
            _produtoRepositoryEf.Update(produto);
            _uow.Commit();
        }

        public void Excluir(Produto produto)
        {
            _produtoRepositoryEf.Delete(produto);
            _uow.Commit();
        }
    }
}
