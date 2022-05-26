using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Municipios
{
    public class MunicipioRepositoryEf : BaseRepositoryEf<Municipio>, IMunicipioRepositoryEf
    {
        private readonly DbTecnomyl _context;
        private readonly DbSet<Municipio> _dbSet;

        public MunicipioRepositoryEf(DbTecnomyl context) : base(context)
        {
            _context = context;
        }

        public async Task<Municipio> ObterPorId(int codigo)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Task<IEnumerable<Municipio>> ObterTodos()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
