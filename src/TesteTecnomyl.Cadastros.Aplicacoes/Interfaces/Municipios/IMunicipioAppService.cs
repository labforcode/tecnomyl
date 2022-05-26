using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Municipios;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Municipios
{
    public interface IMunicipioAppService
    {
        void Adicionar(MunicipioDto municipio);

        void Atualizar(MunicipioDto municipio);

        void Excluir(MunicipioDto municipio);

        Task<MunicipioViewModel> ObterPorId(int codigo);

        Task<IEnumerable<MunicipioViewModel>> ObterTodos();
    }
}