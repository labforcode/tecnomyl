using Microsoft.Extensions.DependencyInjection;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.UoW;
using TesteTecnomyl.Cadastros.Infra.Dados.UoW;

namespace TesteTecnomyl.Cadastros.Infra.IoC
{
    public class InfraInjection
    {
        public static void InfraRegister(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
