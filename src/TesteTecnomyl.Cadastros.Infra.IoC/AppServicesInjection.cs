using Microsoft.Extensions.DependencyInjection;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Produtos;
using TesteTecnomyl.Cadastros.Aplicacoes.Services.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.Services.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.Services.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.Services.Produtos;

namespace TesteTecnomyl.Cadastros.Infra.IoC
{
    public class AppServicesInjection
    {
        public static void ServicesInject(IServiceCollection services)
        {
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IMunicipioAppService, MunicipioAppService>();
            services.AddScoped<IPedidoAppService, PedidoAppService>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
        }
    }
}
