using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Maps.Pedidos
{
    public class ItemPedidoMap : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("itens_pedido");
            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                   .HasColumnName("codigo");

            builder.Property(c => c.Valor)
                   .HasColumnName("valor")
                   .IsRequired();

            builder.Property(c => c.Quantidade)
                   .HasColumnName("quantidade")
                   .IsRequired();

            builder.Property(c => c.Observacao)
                   .HasColumnName("observacao")
                   .HasColumnType("varchar(300)")
                   .IsRequired();

            builder.Property(c => c.CodigoProduto)
                   .HasColumnName("codigo_produto")
                   .IsRequired();
        }
    }
}
