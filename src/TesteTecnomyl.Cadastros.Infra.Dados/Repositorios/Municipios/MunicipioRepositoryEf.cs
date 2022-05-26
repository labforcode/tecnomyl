using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Municipios
{
    public class MunicipioRepositoryEf : BaseRepositoryEf<Municipio>, IMunicipioRepositoryEf
    {
        public MunicipioRepositoryEf(DbTecnomyl context) : base(context)
        {
        }

        public async Task<Municipio> ObterPorId(int codigo)
        {
            try
            {
                return await Context.Municipios.FirstOrDefaultAsync(w => w.Codigo == codigo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Municipio>> ObterTodos()
        {
            try
            {
                return await Context.Municipios.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
