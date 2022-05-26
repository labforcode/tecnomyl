using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Maps.Pedidos
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedidos");
            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                   .HasColumnName("codigo");

            builder.Property(c => c.CodigoCliente)
                    .HasColumnName("codigo_cliente");

            builder.Property(c => c.DataPedido)
                   .HasColumnName("data_pedido")
                   .IsRequired();

            builder.HasOne(c => c.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(c => c.CodigoCliente);
        }
    }
}
