using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Consultas.Pedidos
{
    public class PedidoConsulta : IPedidoConsulta
    {
        public Task<Pedido> ObterPorId()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
