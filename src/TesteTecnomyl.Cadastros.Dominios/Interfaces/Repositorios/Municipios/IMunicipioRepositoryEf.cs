using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios
{
    public interface IMunicipioRepositoryEf : IBaseRepositoryEf<Municipio>
    {
        Task<Municipio> ObterPorId(int codigo);

        Task<IEnumerable<Municipio>> ObterTodos();
    }
}
