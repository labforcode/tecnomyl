using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios;

namespace TesteTecnomyl.Cadastros.Dominios.Consultas.Municipios
{
    public class MunicipioConsulta : IMunicipioConsulta
    {
        private readonly IMunicipioRepositoryEf _municipioRepositoryEf;

        public MunicipioConsulta(IMunicipioRepositoryEf municipioRepositoryEf)
        {
            _municipioRepositoryEf = municipioRepositoryEf;
        }

        public async Task<string> ObterNomeMunicipio(int codigo)
        {
            var municipio = await _municipioRepositoryEf.ObterPorId(codigo);

            return municipio.Nome;
        }

        public async Task<Municipio> ObterPorId(int codigo)
        {
            return await _municipioRepositoryEf.ObterPorId(codigo);
        }

        public async Task<IEnumerable<Municipio>> ObterTodos()
        {
            return await _municipioRepositoryEf.ObterTodos();
        }
    }
}
