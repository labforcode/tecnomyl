using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Consultas.Clientes
{
    public class ClienteConsulta : IClienteConsulta
    {
        public Task<Cliente> ObterPorId()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
