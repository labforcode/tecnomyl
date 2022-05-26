using Microsoft.Extensions.DependencyInjection;
using TesteTecnomyl.Cadastros.Dominios.Comandos.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Comandos.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Comandos.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Comandos.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Produtos;

namespace TesteTecnomyl.Cadastros.Infra.IoC
{
    public class ComandoInjection
    {
        public static void ComandosRegister(IServiceCollection services)
        {
            services.AddScoped<IClienteComando, ClienteComando>();
            services.AddScoped<IMunicipioComando, MunicipioComando>();
            services.AddScoped<IPedidoComando, PedidoComando>();
            services.AddScoped<IProdutoComando, ProdutoComando>();
        }
    }
}
