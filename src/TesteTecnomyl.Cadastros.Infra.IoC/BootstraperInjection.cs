using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TesteTecnomyl.Cadastros.Infra.IoC
{
    public class BootstraperInjection
    {
        public static void Injector(IServiceCollection services, IConfiguration configuration)
        {
            DbTecnomylInjection.ContextInject(services, configuration);

            AppServicesInjection.ServicesInject(services);

            ComandoInjection.ComandosRegister(services);

            ConsultaInjection.ConsultasRegister(services);

            InfraInjection.InfraRegister(services);

            RepositoryEfInjection.RepositoryInject(services);
        }
    }
}
