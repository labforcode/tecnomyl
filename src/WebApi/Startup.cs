using TesteTecnomyl.Cadastros.Infra.IoC;
using WebApi.Configurations;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        ///<inheritdoc'/>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            Injector(services);
            services.AddAutoMapperSetup();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }

        /// <summary>
        /// Chamada para registro de DI
        /// </summary>
        /// <param name="services"></param>
        private void Injector(IServiceCollection services)
        {
            BootstraperInjection.Injector(services, Configuration);
        }
    }
}
