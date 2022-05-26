using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Clientes;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Clientes
{
    public interface IClienteAppService
    {
        void Adicionar(ClienteDto cliente);

        void Atualizar(ClienteDto cliente);

        void Excluir(ClienteDto cliente);

        Task<ClienteViewModel> ObterPorId(int codigo);

        Task<IEnumerable<ClienteViewModel>> ObterTodos();
    }
}
