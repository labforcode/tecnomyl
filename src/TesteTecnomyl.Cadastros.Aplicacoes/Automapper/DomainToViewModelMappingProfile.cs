using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Municipio, MunicipioViewModel>();
            CreateMap<ItemPedido, ItemPedidoViewModel>();
            CreateMap<Pedido, PedidoViewModel>();
        }
    }
}
