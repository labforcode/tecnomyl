using AutoMapper;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Automapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<DomainToViewModelMappingProfile>();
                configuration.AddProfile<DtoToDomainMappingProfile>();
            });
        }
    }
}
