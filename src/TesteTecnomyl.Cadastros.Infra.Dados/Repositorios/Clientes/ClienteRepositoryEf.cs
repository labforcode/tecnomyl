using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Clientes
{
    public class ClienteRepositoryEf : BaseRepositoryEf<Cliente>, IClienteRepositoryEf
    {
        public ClienteRepositoryEf(DbTecnomyl context) : base(context)
        {
        }

        public async Task<Cliente> ObterPorId(int codigo)
        {
            try
            {
                return await Context.Clientes.FirstOrDefaultAsync(w => w.Codigo == codigo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Cliente> ObterPorCpf(string cpf)
        {
            try
            {
                return await Context.Clientes.FirstOrDefaultAsync(w => w.Cpf == cpf);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            try
            {
                return await Context.Clientes.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
