using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Automapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<ClienteDto, Cliente>();
            CreateMap<ProdutoDto, Produto>();
            CreateMap<MunicipioDto, Municipio>();
            CreateMap<ItemPedidoDto, ItemPedido>();
            CreateMap<PedidoDto, Pedido>()
                .ForMember(c => c.ItensPedido, x => x.Ignore());
        }
    }
}
