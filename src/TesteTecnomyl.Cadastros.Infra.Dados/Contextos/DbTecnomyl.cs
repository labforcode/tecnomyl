using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;
using TesteTecnomyl.Cadastros.Infra.Dados.Maps.Clientes;
using TesteTecnomyl.Cadastros.Infra.Dados.Maps.Municipios;
using TesteTecnomyl.Cadastros.Infra.Dados.Maps.Pedidos;
using TesteTecnomyl.Cadastros.Infra.Dados.Maps.Produtos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Contextos
{
    public class DbTecnomyl : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbTecnomyl(DbContextOptions<DbTecnomyl> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.HasDefaultSchema("public");

            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new MunicipioMap());
            builder.ApplyConfiguration(new PedidoMap());
            builder.ApplyConfiguration(new ItemPedidoMap());
            builder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
