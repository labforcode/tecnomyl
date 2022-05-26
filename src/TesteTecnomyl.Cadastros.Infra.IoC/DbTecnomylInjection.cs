using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.IoC
{
    public class DbTecnomylInjection
    {
        public static void ContextInject(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbTecnomyl>(opt => opt.UseNpgsql(configuration.GetConnectionString("dbtecnomyl")));
            services.AddScoped<DbTecnomyl>();
        }
    }
}
