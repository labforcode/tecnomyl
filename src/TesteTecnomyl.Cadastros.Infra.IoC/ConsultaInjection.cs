using Microsoft.Extensions.DependencyInjection;
using TesteTecnomyl.Cadastros.Dominios.Consultas.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Consultas.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Consultas.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Consultas.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Produtos;

namespace TesteTecnomyl.Cadastros.Infra.IoC
{
    public class ConsultaInjection
    {
        public static void ConsultasRegister(IServiceCollection services)
        {
            services.AddScoped<IClienteConsulta, ClienteConsulta>();
            services.AddScoped<IMunicipioConsulta, MunicipioConsulta>();
            services.AddScoped<IPedidoConsulta, PedidoConsulta>();
            services.AddScoped<IProdutoConsulta, ProdutoConsulta>();
        }
    }
}
