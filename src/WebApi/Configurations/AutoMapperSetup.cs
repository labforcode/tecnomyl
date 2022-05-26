using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.Automapper;

namespace WebApi.Configurations
{
    public static class AutoMapperSetup
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="services"></param>
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapper(typeof(Startup));

            // Registering Mappings automatically only works if the
            // Automapper Profile classes are in ASP.NET project
            services.AddSingleton<AutoMapper.IConfigurationProvider>(AutoMapperConfiguration.RegisterMappings());
        }
    }
}
