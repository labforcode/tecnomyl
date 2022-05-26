using Microsoft.Extensions.DependencyInjection;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Produtos;
using TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Clientes;
using TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Municipios;
using TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Pedidos;
using TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Produtos;

namespace TesteTecnomyl.Cadastros.Infra.IoC
{
    public class RepositoryEfInjection
    {
        public static void RepositoryInject(IServiceCollection services)
        {
            services.AddScoped<IClienteRepositoryEf, ClienteRepositoryEf>();
            services.AddScoped<IMunicipioRepositoryEf, MunicipioRepositoryEf>();
            services.AddScoped<IProdutoRepositoryEf, ProdutoRepositoryEf>();
            services.AddScoped<IPedidoRepositoryEf, PedidoRepositoryEf>();
        }
    }
}
