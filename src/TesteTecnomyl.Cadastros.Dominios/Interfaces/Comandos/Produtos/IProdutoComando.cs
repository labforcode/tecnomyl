using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Produtos
{
    public interface IProdutoComando
    {
        void Adicionar(Produto produto);

        void Atualizar(Produto produto);

        void Excluir(Produto produto);
    }
}
