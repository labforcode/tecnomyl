using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Municipios
{
    public interface IMunicipioConsulta
    {
        Task<string> ObterNomeMunicipio(int codigo);

        Task<Municipio> ObterPorId(int codigo);

        Task<IEnumerable<Municipio>> ObterTodos();
    }
}
